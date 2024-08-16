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


            int result = Add(5);
            Console.WriteLine(result);

            PrintName("Art");


            Console.ReadLine();

        }

        static void PrintName(string name = "AL") 
        {
            Console.WriteLine($"My name is {name}");

        }

        static int Add(int a, int b = default) 
        
        { 
            return a + b;
        }


       



    }
}
