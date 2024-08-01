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

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            //Console.WriteLine(message[0]);
            //Console.WriteLine(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();

            for (int i = message.Length - 1; i >= 0; i-- )
            {
                Console.Write(message[i]);
            }

            



            Console.ReadLine();
        }
    }
}
