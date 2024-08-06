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
            int[] numbers = new int []
            {
               90, 199, 22, 50, 30
            };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(numbers, search);
            int position = Array.IndexOf(numbers, search, 1, 2 );

            if (position >= 0)
            {

                Console.WriteLine($"Number {search} has been found at positions {position + 1}");

            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }


            /*int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    position = i; 
                }
            }

            if (position > -1)
            {

                Console.WriteLine($"Number {search} has been found at positions {position + 1}");

            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }*/
            








            Console.ReadLine();
        }
    }
}
