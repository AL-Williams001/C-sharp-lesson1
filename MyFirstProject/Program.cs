using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 23;
            Console.WriteLine(age);

            //long bigNumber = -900000000L;
            var bigNumber = 90000L;
            Console.WriteLine(bigNumber);

            //double negative = -55.2D;
            var negative = -55.2D;
            Console.WriteLine(negative);

            //float precision = 5.000001F;
            var precision = 5.000001F;
            Console.WriteLine(precision);

            //decimal money = 14.99M;
            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Abba";

            var letter = 'a';

            Console.WriteLine(name);
            Console.WriteLine(letter);
            // use var when value is obvious like age, name, etc or it's not big 
            // don't use far for big numbers
            Console.ReadLine();
        }
    }
}
