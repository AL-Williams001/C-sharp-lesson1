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

   


     class Program
    {

       
        static void Main(string[] args)
        {

            Console.Title = ReturnNameAgePair();

            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                
            
            numbers[i] = ReadNumberFromConsole();

            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine();

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Add());


            Console.ReadLine();
        }

       static void something()
        {

        }

        static void conversion()
        {

        }

        static void calculation()
        {

        }

        static int Add()
        {
            return 5 + 5; 
        }



        static int[] CreateRandomArray()
        {
            

            return new int[3] { 0,1,2 };
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }


        static string ReturnName()
        {
            return "Arthur";
        }

        static int ReturnAge()
        {
            return 23;
        }


        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }

        static void PrintIntroduction()
        {
            /*string name = ReturnName();
            int age = ReturnAge();
            string output = $"Hello my name is {name} and my age is {age}";
            Console.WriteLine(output);*/

            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }

    }
}
