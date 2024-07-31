using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your names is {name}");

            //if (name != "")
               // Console.WriteLine("0");

            //if (!name.Equals(""))
               // Console.WriteLine("1");

            if (!string.IsNullOrEmpty(name))
                Console.WriteLine("2");



            Console.ReadLine();
        }
    }
}
