using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgDeAgrupamiento;

namespace Ejecutable
{
    public class Ejecutable
    {
        static void Main()
        {
            Entity a = new Entity(1); Entity b = new Entity(2); Entity c = new Entity(3); Entity d = new Entity(4);
            Distance ab = new Distance(a, b, 10); Distance ac = new Distance(a, c, 20); Distance ad = new Distance(a, d, 15);
            Distance bc = new Distance(b, c, 12); Distance bd = new Distance(b, d, 5); Distance cd = new Distance(c, d, 16);

            List<Distance> list = new List<Distance>() { ab, ac, ad, bc, bd, cd };

            Distance HeapMax = new Distance(list);

        }
    }
}
