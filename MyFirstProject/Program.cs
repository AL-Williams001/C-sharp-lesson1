using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);



            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);*/


            /*if (age >= 18 && age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if (age >= 26)
            {
                Console.WriteLine("You are 26 and older");
            }

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Inavlid age!");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 and older");
                }
                Console.WriteLine("valid age!");
            }*/

            Console.Write("Enter the first number ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

             Console.Write("Enter the second number ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;
            Console.Write("Value of " + numberA + "x" + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else 
            {
                Console.WriteLine("Close but it is wrong!");
            }

       
            Console.ReadLine();
        }
    }
}
