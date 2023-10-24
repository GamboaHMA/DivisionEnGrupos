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

            List<(string, List<double>)> data = proveedor.GetParamEP_EAM_EAJ_EMF();

            foreach (var item in data)
            {
                Entity entity = new Entity(item.Item2, item.Item1);
                entityList.Add(entity);
            }

            Algoritm algoritm = new Algoritm();

            List<List<Entity>> result = algoritm.Clusters(new List<List<Entity>>() { entityList }, 2);

            foreach (var entityGroup in result)
            {
                foreach (var entity in entityGroup)
                {
                    Console.Write( $"{entity} || ");
                }

                Console.WriteLine( );
            }
        }
    }
}
