using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgDeAgrupamiento;

namespace Ejecutable_
{
    public class Ejecutable
    {
        static void Main()
        {
            //Entity a = new Entity(1); Entity b = new Entity(2); Entity c = new Entity(3); Entity d = new Entity(4);
            //Entity e = new Entity(5); Entity f = new Entity(6); Entity g = new Entity(7);

            //Distance ab = new Distance(a, b, 10); Distance ac = new Distance(a, c, 15); Distance ad = new Distance(a, d, 20);
            //Distance ae = new Distance(a, e, 30); Distance af = new Distance(a, f, 22); Distance ag = new Distance(a, g, 23);
            //Distance bc = new Distance(b, c, 12); Distance bd = new Distance(b, d, 5); Distance be = new Distance(b, e, 18);
            //Distance bf = new Distance(b, f, 40); Distance bg = new Distance(b, g, 33);
            //Distance cd = new Distance(c, d, 16); Distance ce = new Distance(c, e, 13); Distance cf = new Distance(c, f, 15); Distance cg = new Distance(c, g, 12);
            //Distance de = new Distance(d, e, 10); Distance df = new Distance(d, f, 11); Distance dg = new Distance(d, g, 21);
            //Distance ef = new Distance(e, f, 20); Distance eg = new Distance(e, g, 18); Distance fg = new Distance(f, g, 36);

            //List<Distance> list = new List<Distance>() { ab, ac, ad, ae, af, ag, bc, bd, be, bf, bg, cd, ce, cf, cg, de, df, dg, ef, eg, fg };

            //Distance HeapMax = new Distance(list);

            //HeapMax.Elimina();

            Algoritm algoritm = new Algoritm();

            List<string> nombresMunicipios = new List<string>() 
            { "Playa", "Plaza de la Revolución", "Centro Habana", "Habana Vieja","Regla", "Habana del Este", "Guanabacoa", "San Miguel del Padrón",
              "Diez de Octubre", "Cerro", "Marianao", "La Lisa", "Boyeros", "Arroyo Naranjo", "Cotorro" };

            List<double> promediosEdad = new List<double>()
            {
39.43145455870,
39.96695443640,
39.56234331390,
39.55456435450,
39.00086003010,
38.86688152580,
38.96207068190,
38.70221693140,
39.39804122680,
39.37038586210,
39.27423686850,
38.73510619920,
39.07173295450,
38.91167716690,
38.60154360090            };

            List<List<double>> coordinate = new List<List<double>>() {
                new List<double> { 54752, 49106, 42203, 27240 },
                new List<double> { 41700, 37022, 38499, 18159 },
                new List<double> { 42302, 37237, 28387, 21168 },
                new List<double> { 26455, 22392, 16048, 13322 },
                new List<double> { 13953, 12280, 8655, 8332 },
                new List<double> { 53058, 47236, 40717, 27739 },
                new List<double> { 40180, 35630, 24667, 25092 },
                new List<double> { 51242, 45492, 28621, 32635 },
                new List<double> { 60446, 53968, 46766, 33757 },
                new List<double> { 38252, 34408, 27371, 21153 },
                new List<double> { 42817, 37508, 27596, 22452 },
                new List<double> { 46328, 41073, 28926, 28569 },
                new List<double> { 64768, 55981, 39686, 38831 },
                new List<double> { 66189, 56839, 38870, 41030 },
                new List<double> {26043, 22691, 15993, 16403 } };

            List<Entity> entities = new List<Entity>();
            foreach (var item in promediosEdad)
            {
                Entity entity = new Entity(coordinate[promediosEdad.IndexOf(item)], nombresMunicipios[promediosEdad.IndexOf(item)]);
                entities.Add(entity);
            }




            //(List<Entity>, List<Entity>) GroupA_GroupB = algoritm.ClustersR(list);

            List<List<Entity>> list_ = new List<List<Entity>>() { entities };

            algoritm.Clusters(list_, 3);

        }
    }
}
