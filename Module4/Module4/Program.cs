using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Program 
    {
        public static void Method1(int x, int y) //two integers
        {
            y = 2 * x; //returning second integer
            Console.WriteLine(y);
        }
        class caller
        {
            public static void Main(string[] args)
            {
                Program.Method1(3,6); //calling method in another class
                Console.ReadLine();
            }
        }
       
    }
}
