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


            string name = "AL";
            int age;
            age = 23; 

            PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();

        }

        static string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
        }

       

        

    }
}
