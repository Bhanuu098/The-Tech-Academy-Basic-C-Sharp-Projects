using System;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is weight of Package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is width of Package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is height of Package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is length of Package?");
            int length = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
               Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if((length + height + width) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is:$" + (length * width * height)/100 + "\nThank you!");
            }
            Console.ReadLine();
        }
    }
}
