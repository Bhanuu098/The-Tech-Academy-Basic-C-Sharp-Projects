using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee (3, "John", "Lewis");
            Employee Employee2 = new Employee (6, "Riya", "Bansal");
            if (Employee1 == Employee2)
            {
                Console.WriteLine("Employee 1 is equal to Employee 2");
            }
            else
            {
                Console.WriteLine("Employee 1 is not equal to Employee 2");
            }
            Console.ReadLine();
        }
    }
}
