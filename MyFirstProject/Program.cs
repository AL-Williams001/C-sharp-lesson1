using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter password again: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {

                    if (password.Length >= 6 && passwordC.Length >=6)
                    {

                    if (password.Equals(passwordC))
                    {
                    Console.WriteLine("Passwords Match");
                    }
                    else
                    {
                    Console.WriteLine("Passwords do not Match");
                    }

                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters");
                    }


                    
                }
                else
                {
                    Console.WriteLine("Please entert a password confirmation.");
                }
            }
            else
            {
                Console.WriteLine("Please entert a password.");
            }




            Console.ReadLine();
        }
    }
}
