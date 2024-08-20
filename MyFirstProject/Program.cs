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

            /* int num = 10;
             string name = "";
             Assign(ref num, ref name);
             Console.WriteLine(num);
             Console.WriteLine(name);*/

            string name = "AL";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();


            if(ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }

            

            Console.ReadLine();

        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {

            name = newName;
            return true;
                
            }
            return false;
        }

        static void Assign(ref int num, ref string name)
        {
            name = "AL";
            num =  20;
        }

    

        



        
      


    }
}
