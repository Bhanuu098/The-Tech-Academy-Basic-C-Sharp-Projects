using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Class1
    {
        public int x;
        public int y;

        public Class1(int Ax, int Ay)
        {
            x = Ax;
            y = Ay;
        }
        public int myMethod() {
            return y = x * 2; //will return second integer y after operation on x
        }
    }
}
