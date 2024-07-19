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
            int age = 10;

            /*if (age >= 0)
            {
                Console.WriteLine("valid");
            }
            else 
            {
                Console.WriteLine("Invalid");
            }*/

            //condition ? true : false

            string result = age >= 0 ? "valid" : "Invalid";
            Console.WriteLine(result);



            Console.ReadLine();
        }
    }
}
