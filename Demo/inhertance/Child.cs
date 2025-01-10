using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.inhertance
{
    internal class Child:parant
    {

        public int Z { get; set; }
        

        public Child(int _x,int _y,int _z):base(_x,_y)
        {     
            Z = _z;
        }
        public override string ToString()
        {
            return $"{X} , {Y} , {Z}";
        }

        public new int Prouduct()
        {
            return X * Y * Z;
        }


    }
}
