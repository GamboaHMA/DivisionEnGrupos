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
            Algoritm algoritm = new Algoritm();

            list = AsignInitialRandomlyCluster(list, level);

            List<double>[] centroids = CalculateCentroids(list);

            bool thereChange = false;

            do
            {
                thereChange = false;
                thereChange = AsignEntityToBestCluster(list, centroids, thereChange);

                if (thereChange) CalculateCentroids(list);

            } while (thereChange);

            return (list, centroids);
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
            foreach (var entity in list[0])           // inicialmente esta lista de listas solo tiene un elemento, que contiene todas las entidades
            {
                entity.group = random.Next(level);
            }

            return Algoritm.ReturnGroups(list[0], level);
        }
        private List<double>[] CalculateCentroids(List<List<Entity>> list)
        {
            List<double>[] centroids = new List<double>[list.Count];
            List<double> coordinates = list[0][0].coordinates;        //tomamos como muestra la coordenada de una entidad

            for (int i = 0; i < centroids.Length; i++)
            {
                centroids[i] = new List<double>();

                for (int j = 0; j < coordinates.Count; j++)
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
