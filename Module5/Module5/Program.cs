using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();
            Employee1.Quit();
            IQuittable Employee2 = new Employee();
            Employee2.Quit();
            Console.ReadLine();
        }
    }
}
