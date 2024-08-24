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



            /*bool success = false;



            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yey" : "Oh no!");*/


            Console.Write("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yey " + result);
            }
            else
            {
                Console.WriteLine("Oh no!");
            }
           




            Console.ReadLine();

        }

        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
       

       

        

    }
}
