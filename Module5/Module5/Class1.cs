using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    interface IQuittable
    {
        void Quit();
    }
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("It is Quittable");
        }
        
        
    }

    
}
