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
        // used to learn and test Watch window for debugging
       
        static void Main(string[] args)
        {


            string name = "AL";
            int age;
            age = 23; 

            if (age > 18)
            {

                Console.WriteLine("18+");

            }

            PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();

        }
        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
          
        }


        static string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

       
       
        

    }
}
