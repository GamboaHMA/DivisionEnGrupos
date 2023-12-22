using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgDeAgrupamiento
{
    public class ClusterEvaluation
    {
        public static double CalinskiHarabasz((List<List<Entity>>, List<double>[], List<double>[]) list)
        {
            double global_variance = GlobalVariance(list);

            double inter_variance = InterVariance(list);

            return global_variance / inter_variance;
        }

        public static double DaviesBouldin((List<List<Entity>>, List<double>[], List<double>[]) list)
        {
            double[] distancia_promedio_respecto_a_centroide_de_elementos = new double[list.Item1.Count];
            double[,] matriz_de_distancias_entre_centroides = new double[list.Item1.Count, list.Item1.Count];
            List<double>[] centroides = new List<double>[list.Item1.Count];

            for (int i = 0; i < list.Item1.Count; i++)
            {
                double promedio_de_cluster_i = GetMediaFromCentroid(list.Item1[i], list.Item2[i]);

                distancia_promedio_respecto_a_centroide_de_elementos[i] = promedio_de_cluster_i;
                centroides[i] = list.Item2[i];
            }

            for (int i = 0; i < matriz_de_distancias_entre_centroides.GetLength(0); i++)
            {
                for (int j = 0; j < matriz_de_distancias_entre_centroides.GetLength(1); j++)
                {
                    if (i != j) matriz_de_distancias_entre_centroides[i, j] = Algoritm.EuclidianDistance(centroides[i], centroides[j]);
                }
            }

            double comodin = int.MinValue;
            double result = 0;

            for (int i = 0; i < centroides.Length; i++)
            {
                comodin = int.MinValue;
                for (int j = 0; j < centroides.Length; j++)
                {
                    if (i == j) continue;

                    double value = (distancia_promedio_respecto_a_centroide_de_elementos[i] +
                        distancia_promedio_respecto_a_centroide_de_elementos[j]) / matriz_de_distancias_entre_centroides[i, j];

                    if (comodin < value) comodin = value;
                }

                result += comodin;
            }

            if (list.Item1.Count != 0) return result / list.Item1.Count;
            else return result;
        }





//--------------------------------------------------------------------------------------------------------------

        private static double GetMediaFromCentroid(List<Entity> entities, List<double> centroid)
        {
            double result = 0;

            for (int i = 0; i < entities.Count; i++)
            {
                result += Algoritm.EuclidianDistance(entities[i].coordinates, centroid);
            }

            if (entities.Count > 0)
            {
                result = result / entities.Count;
                return result;
            }

            else return result;
        }

        private static double GlobalVariance((List<List<Entity>>, List<double>[], List<double>[]) list)
        {
            List<double> global_entity_media = GetMedia(list.Item1);

            double result = 0;

            for (int i = 0; i < list.Item1.Count; i++)
            {
                result += list.Item1[i].Count * Math.Pow(Algoritm.EuclidianDistance(global_entity_media, list.Item2[i]), 2);
            }

            if (list.Item1.Count > 1)
            {
                result = result / (list.Item1.Count - 1);
                return result;
            }
            else return result;
        }

        private static double InterVariance((List<List<Entity>>, List<double>[], List<double>[]) list)
        {
            int count = 0;
            double result = 0;

            for (int i = 0; i < list.Item1.Count; i++)
            {
                for (int j = 0; j < list.Item1[i].Count; j++)
                {
                    //hallamos la distancia euclidiana entre cada elemento con respecto a su centroide
                    result += Math.Pow(Algoritm.EuclidianDistance(list.Item1[i][j].coordinates, list.Item2[i]), 2);
                    count++;
                }
            }

            if (count - list.Item1.Count > 1)
            {
                result = result / (count - list.Item1.Count);
                return result;
            }
            else return result;
        }

        private static List<double> GetMedia(List<List<Entity>> list)
        {
            int count = 0;

            List<double> result = new List<double>();
            foreach (var item in list[0][0].coordinates)
            {
                result.Add(0);
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Algoritm.VectorialSum(result, list[i][j].coordinates);
                    count++;
                }
            }

            Algoritm.VectorialDiv(result, count);

            return result;
        }
    }
}
