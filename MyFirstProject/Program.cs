using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;


namespace MyFirstProject
{

   


     class Program
    {

       
        static void Main(string[] args)
        {

            int[] numbers = new int[]
            {
               0, 1, 2, 3, 4, 5, 100
            };

            int result = SumOfNumbers(numbers);

            if(result > -1)
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty Array!");
            }

            if (SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is: {total}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty Array!");
            }

            Console.ReadLine();

        }

        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {


                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }

                return total;

            }

            return -1;

        }

        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {

                foreach (var item in numbers)
                {
                    total += item;
                }

                return true;

            }

            return false;

        }

    }
}
