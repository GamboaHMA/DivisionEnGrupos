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
        public (List<List<Entity>>, List<double>[], List<double>[]) KMeans(List<List<Entity>> list, int level)
        {
            List<double> reference = list[0][0].coordinates;//referencia para saber que cant de parámetros tiene cada entidad

            Algoritm algoritm = new Algoritm();

            list = AsignInitialRandomlyCluster(list, level);//asignamos a cada entidad un grupo aleatorio

            List<double>[] centroids = CalculateCentroids(list, reference.Count);//calculamos centroides a partir de los grupos asignados anteriormente

            bool thereChange = false;//variable que controlará si hay cambios de grupos por parte de las entidades a la hora de asignar al grupo más cercano

            do
            {
                thereChange = false;
                thereChange = AsignEntityToBestCluster(list, centroids, thereChange);//asignar al grupo más cercano

                list = Algoritm.UpdateGroups(list, level);//reubicar cada entidad en el grupo que le corresponda en caso de haber algún cambio

                if (thereChange) CalculateCentroids(list, reference.Count);//recalcular los centroides de cada grupo en caso de que haya algún cambio

            } while (thereChange);

            List<double>[] variances = GetVariancesInEntities(list, centroids);//calcular las varianzas de cada grupo una vez bien asignados

            return (list, centroids, variances);
        }


        public (List<List<Entity>>, List<double>[], List<double>[]) KMeans_Eps(List<List<Entity>> list, double eps) //recibe un epsilon que seria la distancia minima de cada ent en cada cluster
        {
            List<double> reference = list[0][0].coordinates;//referencia para saber que cant de parámetros tiene cada entidad

            List<Entity> listIteration = new List<Entity>();//inicializamos la lista por la cual vamos a iterar

            GetInitialList(listIteration, list[0]);//generamos lista de entidades por la cual vamos a iterar

            Queue<Entity> Queue = new Queue<Entity>();

            int count = 0;//contador que usaremos para asignar los grupos

            foreach (var item in listIteration)
            {
                if (item.group == 0)
                {
                    list.Add(new List<Entity>());//cada vez que vamos a crear un grupo nuevo agregamos grupo vacío a la lista a retornar
                    Queue.Enqueue(item);//agregamos la entidad inicial, la cual dará comienzo al algoritmo 
                    list[0].Remove(item);//removemos de la lista proveedora
                    list[count + 1].Add(item);//agregamos la entidad inicial al grupo nuevo

                    item.group = count + 1;//actualizamos el valor del grupo de la entidad inicial

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
            List<double>[] variances = GetVariancesInEntities(list, centroides);

            return (list, centroides, variances);
        }

        public (List<List<Entity>>, List<double>[], List<double>[]) KMeans_ArbCentroids(List<List<Entity>> list, int level)
        {
            List<double> reference = list[0][0].coordinates;

            (List<double>, List<double>) vectorialLimit = GetVectorLimits(list);//tomamos los límites inferior y superior de la muestra
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

            List<double>[] variances = GetVariancesInEntities(list, centroids);

            return (list, centroids, variances);

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
                if (entity.group == 0 &&
                   Algoritm.EuclidianDistance(actualEntity.coordinates, entity.coordinates) < eps)
                {
                    entities[0].Remove(entity);//removemos del grupo proveedor, o sea el primero de la lista
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
                    Algoritm.VectorialSum(centroids[i], list[i][j].coordinates);
                }

                Algoritm.VectorialDiv(centroids[i], list[i].Count);
            }

            return centroids;
        }

        private List<double>[] GetVariancesInEntities(List<List<Entity>> list, List<double>[] centroids)
        {
            List<double>[] result = new List<double>[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                List<double> variance = Algoritm.GetVariance(centroids[i], list[i]);

                result[i] = variance;
            }

            return result;
        }

    }
}