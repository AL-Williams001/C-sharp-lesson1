using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;


namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0;i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine( "Printing even numbers: ");

            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Environment.NewLine + "Printing odd numbers: ");

            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }



            Console.ReadLine();
        }
    }
}
