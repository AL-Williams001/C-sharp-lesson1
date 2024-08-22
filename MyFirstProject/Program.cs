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



            bool looping = true;

            while (looping)
            {

                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a number less than 2b!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something has gone wrong!");
                }

            }


            Console.WriteLine("Goodbye!");           

            Console.ReadLine();

        }

       

        

    }
}
