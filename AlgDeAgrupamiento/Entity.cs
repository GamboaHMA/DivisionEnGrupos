using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDeAgrupamiento
{
    public class Entity
    {
        public int value { get; set; }
        public int group { get; set; }

        public Entity(int value)
        {
            this.value = value;
            group = 0;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
