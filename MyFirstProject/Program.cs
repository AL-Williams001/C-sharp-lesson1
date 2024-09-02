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
       

        class Person
        {
            public string name;
            public int age;
            public int number;

            public Person(string name, int age, int number) 
            {
                this.name = name;
                this.age = age;
                this.number = number;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}\nNumbers: {number}";
            }


        }

        static void Main(string[] args)
        {
            Person person = new Person("AL", 23, 1);
            //Console.WriteLine($"Name: {person.name}\nAge: {person.age}");
            Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();
        }

        static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}\nNumbers: {person.number}";
            //person.number
        }

       /* static string ReturnDetails(string name, int age)
        {
            return $"Name: {name}\nAge: {age}";
        }*/







    }
}
