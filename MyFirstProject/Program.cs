using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                9, 7, 6, 2, 8, 4, 1, 3, 5,
            };


            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
          
            Console.ReadLine();
        }
    }
}
