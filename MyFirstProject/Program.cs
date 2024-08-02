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

            int num1 = 5;
            int num2 = 10;
            int num3 = 15;



            /*Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            numbers[4] = Convert.ToInt32(Console.ReadLine());

*/



            //Console.WriteLine($"{num1} {num2} {num3}");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            int[] numbers = new int[5];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }



            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();


            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

          
            Console.ReadLine();
        }
    }
}
