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





            string message = "C# is awesome";
            //char []
            /*Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
            Console.WriteLine(message[3]);*/

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            bool contains = false;

            for (int i = 0; i < message.Length;i++)
            {
                if (message[i].Equals('a'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);

            Console.ReadLine();
        }
    }
}
