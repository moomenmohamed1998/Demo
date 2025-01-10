using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.inhertance
{
    internal class parant
    {
        public int X { get; set; }
        public int Y { get; set; }


        public parant( int _x, int _y)
        {
            X = _x;
            Y = _y;

        }
        public override string ToString()
        {
            return $"{X} , {Y}";
        }

        public int Prouduct()
        {
            return X * Y;
        }

    }
}
