using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Hello World");
            Console.WriteLine("I have now done an update on my work Computer!");
            while (x == 1)
            {

            
                string feldercarp = Console.ReadLine();
                if (feldercarp == "Hey You")
                {
                    Console.WriteLine("You have a match.");
                    x = 0;
                }
                else
                {
                    Console.WriteLine("Please Try again");
                }
            }

            Console.ReadKey();
        }
    }
}
