using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgDeAgrupamiento;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgDeAgrupamiento;
using ProveedorDeDatosDePoblacionCuba;

namespace Ejecutable_
{
    public class Ejecutable
    {
        static void Main()
        {
            Data proveedor = new Data();

            List<Entity> entityList = new List<Entity>();

            List<(string, List<double>, string)> data = proveedor.GetParamEP_EAM_EAJ_EMF();

            FillEntityList(data, entityList, 2);


            Algoritm algoritm = new Algoritm();
            K_Means K_Means = new K_Means();

            // List<List<Entity>> result = algoritm.Clusters(new List<List<Entity>>() { entityList }, 3);

            //(List<List<Entity>>, List<double>[], List<double>[]) resultKM = K_Means.KMeans(new List<List<Entity>>() { entityList }, 10);
            //(List<List<Entity>>, List<double>[], List<double>[]) resultKM_Arb = K_Means.KMeans_ArbCentroids(new List<List<Entity>>() { entityList }, 10);
            (List<List<Entity>>, List<double>[], List<double>[]) resultKM_Eps = K_Means.KMeans_Eps(new List<List<Entity>>() { entityList }, 0.05);


            //Console.WriteLine( "Minimiazar distancias maxima");
            //Console.WriteLine( );
            //foreach (var entityGroup in result)
            //{
            //    Console.WriteLine($"Cluster {result.IndexOf(entityGroup)}");
            //    foreach (var entity in entityGroup)
            //    {
            //        Console.WriteLine( $"{entity} ");
            //    }

            //    Console.WriteLine( );
            //}

            Console.WriteLine("K-Means");
            ImprimeResultados(resultKM_Eps);
        }

        private static void FillEntityList(List<(string, List<double>, string)> data, List<Entity> entityList, int option)
        {
            switch (option)
            {
                case 1://fuerza bruta
                    foreach (var item in data)
                    {
                        Entity entity = new Entity(item.Item2, new List<string>() { item.Item1, item.Item3 });
                        entityList.Add(entity);
                    }
                    break;

                case 2://razon de proporcionalidad
                    foreach (var item in data)
                    {
                        List<double> coordinates = new List<double>
                        {
                            item.Item2[1] / item.Item2[2],//relación de adulto mayor con respecto a adulto joven
                            item.Item2[1] / item.Item2[0],//relación de adulto mayor con respecto a edad pediátrica
                            item.Item2[2] / item.Item2[0] //relación de adulto joven con respecto a edad pediátrica
                        };

                        Entity entity = new Entity(coordinates, new List<string>() { item.Item1, item.Item3 });
                        entityList.Add(entity);
                    }
                    break;

                default:
                    break;
            }
        }

        private static void ImprimeResultados((List<List<Entity>>, List<double>[], List<double>[]) result)
        {
            Console.WriteLine();
            for (int i = 0; i < result.Item1.Count; i++)
            {
                Console.WriteLine($"Cluster{i} Cant({result.Item1[i].Count})\n\nParámetros:\n{ImprimeCoordenadas(result.Item2[i])}\nvarianza:\n{ImprimeCoordenadas(result.Item3[i])}\nMunicipios:");
                for (int j = 0; j < result.Item1[i].Count; j++)
                {
                    Console.WriteLine(result.Item1[i][j] + $"({result.Item1[i][j].caracteristics[1]})");
                }
                Console.WriteLine("------------------------------------");
            }

        }

        private static string ImprimeCoordenadas(List<double> item2)
        {
            string[] info = { "AdMayor/AdJoven ", "AdMayor/EdadPediátrica", "AdJoven/EdadPediátrica" };
            string result = "";

            for (int i = 0; i < item2.Count; i++)
            {
                result = result + info[i] + item2[i].ToString(" #.0000"); result += "\n";
            }

            return result;
        }

    }
}