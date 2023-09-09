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
            Entity a = new Entity(1); Entity b = new Entity(2); Entity c = new Entity(3); Entity d = new Entity(4);
            Entity e = new Entity(5); Entity f = new Entity(6); Entity g = new Entity(7);

            Distance ab = new Distance(a, b, 10); Distance ac = new Distance(a, c, 15); Distance ad = new Distance(a, d, 20);
            Distance ae = new Distance(a, e, 30); Distance af = new Distance(a, f, 22); Distance ag = new Distance(a, g, 23);
            Distance bc = new Distance(b, c, 12); Distance bd = new Distance(b, d, 5); Distance be = new Distance(b, e, 18);
            Distance bf = new Distance(b, f, 40); Distance bg = new Distance(b, g, 33);
            Distance cd = new Distance(c, d, 16); Distance ce = new Distance(c, e, 13); Distance cf = new Distance(c, f, 15); Distance cg = new Distance(c, g, 12);
            Distance de = new Distance(d, e, 10); Distance df = new Distance(d, f, 11); Distance dg = new Distance(d, g, 21);
            Distance ef = new Distance(e, f, 20); Distance eg = new Distance(e, g, 18); Distance fg = new Distance(f, g, 36);

            List<Distance> list = new List<Distance>() { ab, ac, ad, ae, af, ag, bc, bd, be, bf, bg, cd, ce, cf, cg, de, df, dg, ef, eg, fg };

            Distance HeapMax = new Distance(list);

            HeapMax.Elimina();

            Algoritm algoritm = new Algoritm();

            (List<Entity>, List<Entity>) GroupA_GroupB = algoritm.Clusters(list);
        }
    }
}
