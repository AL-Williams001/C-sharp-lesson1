﻿using System;
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
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;

            }
        }

        static void Main(string[] args)
        {

            /* string name = "AL";
             int age = 23;
             int birthMonth = 9;

             Person person;

             person.name = "AL";
             person.age = 23;
             person.birthMonth = 9;

             Console.WriteLine($"{name} - {age} - {birthMonth}");
             Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");


             string newName = "";
             int newAge = 0;
             int newBirthMonth = 0;
             ReturnPerson(ref newName, ref newAge, ref newBirthMonth);
             Console.WriteLine($"{newName} - {newAge} - {newBirthMonth}");*/


            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth} - {person.number}");


            Console.ReadLine();

        }

        static Person ReturnPerson()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

          /*  Person person;

            person.name = name;
            person.age = age;
            person.birthMonth = birthMonth;
            person.number = number*/;

            //return person;

            return new Person(name, age, birthMonth, number);
        } 



        


        /*static void ReturnPerson(ref string name , ref int age, ref int birthMonth)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            birthMonth = Convert.ToInt32(Console.ReadLine());




        }*/


                    
       
        

    }
}
