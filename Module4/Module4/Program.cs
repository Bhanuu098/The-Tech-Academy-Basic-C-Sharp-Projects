using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    internal class Program //class
    {
        static int myMethod(int x, int y) // 2 integers
        {
            return 2* x;
        }
        static void Main(string[] args)
        {
            int y = myMethod(2, 4); //return the second integer on screen
            Console.WriteLine(y); 
            Console.ReadLine();
        }
    }
}
