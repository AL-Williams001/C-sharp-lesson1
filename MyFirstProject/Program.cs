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
    internal class Program
    {
        static void Main(string[] args)
        {


            int num = 10;
            int length = 10;
            int[] result = new int[length];
            int counter = 0;

            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num * i;
                
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }


            Console.ReadLine();
        }
    }
}
