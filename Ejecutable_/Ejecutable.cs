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

            foreach (var item in data)
            {
                Entity entity = new Entity(item.Item2, new List<string>() { item.Item1, item.Item3});
                entityList.Add(entity);
            }

            Algoritm algoritm = new Algoritm();
            K_Means K_Means = new K_Means();

           // List<List<Entity>> result = algoritm.Clusters(new List<List<Entity>>() { entityList }, 3);

            (List<List<Entity>>, List<double>[]) resultKM = K_Means.KMeans(new List<List<Entity>>() { entityList }, 5);

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
            Console.WriteLine( );
            for (int i = 0; i < resultKM.Item1.Count; i++)
            {
                Console.WriteLine($"Cluster {i} -> {ImprimeCoordenadas(resultKM.Item2[i])}");
                for (int j = 0; j < resultKM.Item1[i].Count; j++)
                {
                    Console.WriteLine(resultKM.Item1[i][j] + $"({resultKM.Item1[i][j].caracteristics[1]})");
                }
                Console.WriteLine();
            }
        }

        private static string ImprimeCoordenadas(List<double> item2)
        {
            string[] info = { "EdadPediatrica ", "EdadAdultoJoven ", "EdadAdultoMayor ", "EdadMujerFertil " };
            string result = "(Cant) ";

            for (int i = 0; i < item2.Count; i++)
            {
                result = result + info[i] + item2[i].ToString("#.00"); result += "  ";
            }

            return result;
        }
    }
}
