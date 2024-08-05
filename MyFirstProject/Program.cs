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
                0, 1, 2, 3, 4, 5,
            };

            int[] sortedNumbers = new int[numbers.Length];

            int x = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            foreach (var num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }

            //Array.Reverse(numbers);

           /* foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }*/

            Console.ReadLine();
        }
    }
}
