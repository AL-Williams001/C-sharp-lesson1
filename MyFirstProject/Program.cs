using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           


            string message = "Hello";
            string compare = "Hello";


            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //if (name != "")
            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is " + name);
            }
            else
            {
                Console.WriteLine("Invalid name Input");
            }




            Console.ReadLine();
        }
    }
}
