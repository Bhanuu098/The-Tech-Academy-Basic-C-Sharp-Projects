using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 first = new Class1(5, 10);
            Console.WriteLine(first.myMethod()); //Calling Method
            Console.ReadLine();
        }
    }
}
