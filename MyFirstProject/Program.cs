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

            int age = 55;


            if (age > 18 && age < 30) // use conditional to get a specific range
            {
                Console.WriteLine("Over 18");

            }
            else if(age > 30 && age < 50)
            {
                Console.WriteLine("Over 30");
            }
            else if (age > 50)
            {
                Console.WriteLine("Over 50");
            }



            Console.ReadLine();

        }
        
       
       
        

    }
}
