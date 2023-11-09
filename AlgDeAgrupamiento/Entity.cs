using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDeAgrupamiento
{
    public class Entity
    {
        public List<double> coordinates { get; set; }
        public int group { get; set; }
        public List<string> caracteristics { get; set; }

        public Entity(List<double> coordinates, List<string> caracteristics)
        {
            this.caracteristics = new List<string>();
            this.coordinates = new List<double>();
            this.coordinates = coordinates;
            group = 0;
            foreach (var item in caracteristics)
            {
                this.caracteristics.Add(item);
            }
        }

        public override string ToString()
        {
            return caracteristics[0];         //coloquemos siempre el nombre como primer elemento de las caracteristicas
        }
    }
}
