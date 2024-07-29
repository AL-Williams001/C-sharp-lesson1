using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            string path = "c:\\Users\\CoffeeNCode\\Desktop\\C# Course\nNew Line Test";
            Console.WriteLine(path);
            Console.WriteLine(speech);


            path = @"c:\Users\CoffeeNCode\Desktop\C# Course";
            Console.WriteLine(path);

            string name = @"Hello ""Someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
