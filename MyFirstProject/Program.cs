﻿using System;
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
            

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            if (name != string.Empty)

            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty ");
            }

           





            Console.ReadLine();
        }
    }
}
