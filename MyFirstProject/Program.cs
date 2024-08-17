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


            string nameInput = "AL";
            int ageInput = 23;
            string addressInput = "1 Something Road";

            PrintDetails(address: addressInput,
                        age: ageInput, 
                        name: nameInput);

        


            Console.ReadLine();

        }

        
       static void PrintDetails (string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }



    }
}
