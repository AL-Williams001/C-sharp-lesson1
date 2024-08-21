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

           
            int width = ReadInt("width");
            int height = ReadInt("height");


            int result = CalcArea(width, height);

            Console.WriteLine($"The area is {result}");


            Console.ReadLine();

        }

        static int CalcArea(int width, int height)
        {
            return (width * height) / 2;
        }

        static int ReadInt(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

       

       
    

        



        
      


    }
}
