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

        public Entity(List<double> coordinates)
        {
            this.coordinates = new List<double>();
            this.coordinates = coordinates;
            group = 0;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
