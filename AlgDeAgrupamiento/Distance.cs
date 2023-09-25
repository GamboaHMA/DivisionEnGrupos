using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDeAgrupamiento
{
    public class Distance
    {
        public List<Entity> entities {  get; set; }
        public Entity? Element1 { get; set; }
        public Entity? Element2 { get; set; }
        public double Value { get; set; }

        

        public Distance? Root { get; set; }
        public Distance? Parent { get; set; }
        public Distance? Left { get; set; }
        public Distance? Right { get; set; }
        public List<Distance>? Arr { get; set; }

        public Distance()
        {

        }

        public Distance(Entity Element1, Entity Element2, double Distance)
        {
            Root = this;
            Parent = this;
            this.Element1 = Element1;
            this.Element2 = Element2;
            Value = Distance;
            Arr = new List<Distance> { this };
        }

        public Distance(List<Distance> Array)
        {
            Link(Array);

            for (int i = Array.Count / 2; i >= 0; i--)
            {
                HeapiFy(Array, i);
            }

            UpDateRoot(Array);

            Element1 = Array[0].Element1;
            Element2 = Array[0].Element2;
            Value = Array[0].Value;
            Parent = Array[0].Parent;
            Left = Array[0].Left;
            Right = Array[0].Right;
            Root = Array[0].Root;
            Arr = Array[0].Arr;
        }

        public void HeapiFy(List<Distance> Array, int i)
        {
            int l = left(i);
            int r = right(i);
            int max;
            if (l <= Array.Count - 1 && Array[l].Value > Array[i].Value) max = l;
            else max = i;

            if (r <= Array.Count - 1 && Array[r].Value > Array[max].Value) max = r;
            
            if (max != i)
            {
                if (max == l)
                {
                    if (Array[i].Parent == Array[i]) Array[l].Parent = Array[l];
                    else 
                    {
                        Array[l].Parent = Array[i].Parent;
                        if (Array[i].Parent.Left == Array[i]) Array[i].Parent.Left = Array[l];
                        else Array[i].Parent.Right = Array[l];
                    } 
                    
                    Array[i].Parent = Array[l]; 
                    Array[i].Left = Array[l].Left; 
                    Array[l].Left = Array[i]; Distance comodin = Array[l].Right;
                    Array[l].Right = Array[i].Right;
                    Array[i].Right = comodin;
                    
                    if(r <= Array.Count - 1)
                    {
                        Array[r].Parent = Array[l];
                    }

                }

                else
                {
                    if (Array[i].Parent == Array[i]) Array[r].Parent = Array[r];
                    else
                    {
                        Array[r].Parent = Array[i].Parent;
                        if (Array[i].Parent.Left == Array[i]) Array[i].Parent.Left = Array[r];
                        else Array[i].Parent.Right = Array[r];
                    }

                    Array[i].Parent = Array[r]; 
                    Array[l].Parent = Array[r];
                    Array[i].Left = Array[r].Left; 
                    Array[i].Right = Array[r].Right;
                    Array[r].Left = Array[l]; 
                    Array[r].Right = Array[i];
                }

                Distance comdin = Array[i];
                Array[i] = Array[max];
                Array[max] = comdin;

                HeapiFy(Array, max); 
            }
                
        }

        public void Link(List<Distance> Array)
        {
            Array[0].Root = Array[0];
            for (int i = 0; i < Array.Count; i++)
            {
                int l = left(i);
                int r = right(i);
                int p = parent(i);

                if (p >= 0) { Array[i].Parent = Array[p]; Array[i].Root = Array[p].Root; }
                if (l < Array.Count) Array[i].Left = Array[l];
                if (r < Array.Count) Array[i].Right = Array[r];

                Array[i].Arr = Array;
            }
        }


        public void UpDateRoot(List<Distance> Array)
        {
            Distance root = Array[0];
            Array[0].Parent = Array[0];
            Array[0].Root = root;
            for (int i = 0; i < Array.Count; i++)
            {
                Array[i].Root = root;
            }
        }
        public void Elimina()
        {
            if (Arr[Arr.Count - 1] == Arr[Arr.Count - 1].Parent.Left) Arr[Arr.Count - 1].Parent.Left = null;
            else Arr[Arr.Count - 1].Right = null; 

            Arr[Arr.Count - 1].Left = Arr[0].Left; Arr[Arr.Count - 1].Right = Arr[0].Right;
            Arr[Arr.Count - 1].Parent = Arr[Arr.Count - 1]; 
            Arr[Arr.Count - 1].Left.Parent = Arr[Arr.Count - 1]; Arr[Arr.Count - 1].Right.Parent = Arr[Arr.Count - 1];


            Distance comodin = Arr[Arr.Count - 1];
            Arr[Arr.Count - 1] = Arr[0];
            Arr[0] = comodin;

            Arr.RemoveAt(Arr.Count - 1);

            HeapiFy(Arr, 0);

            UpDateRoot(Arr);
        }



        public int left(int i) { return 2 * i + 1; }
        public int right(int i) { return 2 * i + 2; }
        public int parent(int i) { return ((i + 1) / 2) - 1; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
