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

    class Test
    {
        public static void something()
        {
            Console.WriteLine();
        }
    }


     class Program
    {
        static void Main(string[] args)
        {
            
            Test.something();

            WelcomeMessage();
            

            Console.ReadLine();
        }


        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome AL");
        }


    }
}
