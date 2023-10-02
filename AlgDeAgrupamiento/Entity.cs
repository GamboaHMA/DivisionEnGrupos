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
        public string name { get; set; }

        public Entity(List<double> coordinates, string name)
        {
            this.coordinates = new List<double>();
            this.coordinates = coordinates;
            group = 0;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
