using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgDeAgrupamiento
{
    public class K_Means
    {
        public (List<List<Entity>>, List<double>[]) KMeans(List<List<Entity>> list, int level)
        {
            List<double> reference = list[0][0].coordinates;

            Algoritm algoritm = new Algoritm();

            list = AsignInitialRandomlyCluster(list, level);

            List<double>[] centroids = CalculateCentroids(list, reference.Count);

            bool thereChange = false;

            do
            {
                thereChange = false;
                thereChange = AsignEntityToBestCluster(list, centroids, thereChange);

                list = Algoritm.UpdateGroups(list, level);

                if (thereChange) CalculateCentroids(list, reference.Count);

            } while (thereChange);

            return (list, centroids);
        }

        public (List<List<Entity>>, List<double>[]) KMeans_Eps(List<List<Entity>> list, double eps) //recibe un epsilon que seria la distancia minima de cada ent en cada cluster
        {
            List<double> reference = list[0][0].coordinates;

            List<Entity> listIteration = new List<Entity>();

            GetInitialList(listIteration, list[0]);//generamos lista de entidades por la cual vamos a iterar
 
            Queue<Entity> Queue = new Queue<Entity>();

            int count = 0;//contador que usaremos para asignar los grupos

            foreach (var item in listIteration)
            {
                if (item.group == 0)
                {
                    Queue.Enqueue(item);//agregamos la entidad inicial, la cual dará comienzo al algoritmo 
                    list[0].Remove(item);
                    list.Add(new List<Entity>() { item } );//agregamos la entidad inicial al grupo nuevo

                    item.group = count + 1;//actualizamos el valor del grupo

                    while (Queue.Count != 0)
                    {
                        Entity actualEntity = Queue.Dequeue();//extraemos la primera entidad de la cola

                        FillGroup(list, actualEntity, eps, count, Queue);//agrupamos a toda entidad cercana

                    }
                    count++;
                }
            }
            list.Remove(list[0]);//removemos la lista por la que ibamos iterando, que se queda vacía al temrminar el algoritmo

            List<double>[] centroides = CalculateCentroids(list, reference.Count);

            return (list, centroides);
        }

        public (List<List<Entity>>, List<double>[]) KMeans_ArbCentroids(List<List<Entity>> list, int level)
        {
            List<double> reference = list[0][0].coordinates;

            (List<double>, List<double>) vectorialLimit = GetVectorLimits(list);//tomamos los limites inferior y superior de la muestra
            List<double>[] centroids = new List<double>[level];
            GetRandomCentroids(centroids, level, vectorialLimit);//inicializamos centroides arbitrarios

            bool thereChange = false;

            do
            {
                thereChange = false;
                thereChange = AsignEntityToBestCluster(list, centroids, thereChange);

                list = Algoritm.UpdateGroups(list, level);

                if (thereChange) CalculateCentroids(list, reference.Count);

            } while (thereChange);

            return (list, centroids);

        }

        private void GetRandomCentroids(List<double>[] centroids, int level, (List<double>, List<double>) vectorialLimit)
        {
            Random random = new Random();

            List<double> limiteInferior = vectorialLimit.Item1;
            List<double> limiteSuperior = vectorialLimit.Item2;

            for (int i = 0; i < level; i++)
            {
                centroids[i] = new List<double>();
                for (int j = 0; j < limiteInferior.Count; j++)
                {
                    (int, int) randomDouble = ((int)(limiteInferior[j] * 100000), (int)(limiteSuperior[j] * 100000));
                    double randomDouble_ = random.Next(randomDouble.Item1, randomDouble.Item2);
                    double resultRandom = randomDouble_ / 100000;
                    double value = limiteInferior[j] + resultRandom;

                    centroids[i].Add(value);
                }
            }
        }

        private (List<double>, List<double>) GetVectorLimits(List<List<Entity>> list)
        {
            List<double> limiteInferior = new List<double>();
            foreach (var item in list[0][0].coordinates) { limiteInferior.Add(double.MaxValue); }            

            List<double> limiteSuperior = new List<double>();
            foreach (var item in list[0][0].coordinates) { limiteSuperior.Add(double.MinValue); }

            foreach (var item in list[0])
            {
                for (int i = 0; i < item.coordinates.Count; i++)
                {
                    if (limiteInferior[i] > item.coordinates[i]) limiteInferior[i] = item.coordinates[i];
                    if (limiteSuperior[i] < item.coordinates[i]) limiteSuperior[i] = item.coordinates[i];
                }
            }

            return (limiteInferior, limiteSuperior);
        }

        private void FillGroup(List<List<Entity>> entities, Entity actualEntity, double eps, int count, Queue<Entity> Queue)
        {
            List<Entity> entitiesIteration = new List<Entity>();
            foreach (var item in entities[0])
            {
                entitiesIteration.Add(item);
            }
            foreach (var entity in entitiesIteration)
            {
                if(entity.group == 0 && 
                   Algoritm.EuclidianDistance(actualEntity.coordinates, entity.coordinates) < eps)
                {
                    entities[0].Remove(entity);//removemos del antiguo grupo(el primero que esta en la lista de listas)
                    entities[count + 1].Add(entity);//agregamos a nuevo grupo
                    Queue.Enqueue(entity);

                    entity.group = count + 1;//actualizamos el valor del grupo
                }
            }
        }

        private void GetInitialList(List<Entity> list, List<Entity> entities)
        {
            foreach (var item in entities)
            {
                list.Add(item);
            }
        }






        private bool AsignEntityToBestCluster(List<List<Entity>> list, List<double>[] centroids, bool thereChange)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    int bestCluster = ToBestCluster(list[i][j], centroids);
                    if (bestCluster != list[i][j].group) 
                    {
                        list[i][j].group = bestCluster;
                        thereChange = true;
                    }
                }
            }

            return thereChange;
        }

        private int ToBestCluster(Entity entity, List<double>[] centroids)
        {
            int result = 0;
            double min = int.MaxValue;

            for (int i = 0; i < centroids.Length; i++)
            {
                double distance = Algoritm.EuclidianDistance(entity.coordinates, centroids[i]);
                if (distance < min)
                {
                    min = distance; result = i; 
                }
            }

            return result;
        }

        private List<List<Entity>> AsignInitialRandomlyCluster(List<List<Entity>> list, int level)
        {
            Random random = new Random();
            foreach (var item in list)           // inicialmente esta lista de listas solo tiene un elemento, que contiene todas las entidades
            {
                foreach (var entity in item)
                {
                    entity.group = random.Next(level);
                }
            }
            

            return Algoritm.UpdateGroups(list, level);
        }
        private List<double>[] CalculateCentroids(List<List<Entity>> list, int count)
        {
            List<double>[] centroids = new List<double>[list.Count];

            for (int i = 0; i < centroids.Length; i++)
            {
                centroids[i] = new List<double>();

                for (int j = 0; j < count; j++)
                {
                    centroids[i].Add(0);                    //inicializamos cada coordenada de cada centroide
                }
            }

            for (int i = 0; i < list.Count; i++)            //hallamos el promedio de cada cluster
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    VectorialSum(centroids[i], list[i][j].coordinates);
                }

                VectorialDiv(centroids[i], list[i].Count);
            }

            return centroids;
        }

        private void VectorialDiv(List<double> centroids, int count)     //divide cada coordenada del vector entre el entero count
        {
            for (int i = 0; i < centroids.Count; i++)
            {
                centroids[i] = centroids[i] / count;
            }
        }

        private void VectorialSum(List<double> list, List<double> coordinates)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += coordinates[i];
            }
        }

    }
}
