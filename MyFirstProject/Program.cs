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
            private string name;
            private int age;
            private string test = "hello";// global scope
            

            public Person(string name, int age) 
            {
                this.name = name;
                this.age = age;
                string test = "hi";// local scope and it takes priotity over global scope
                Console.WriteLine(test);

            }

            public void SetName(string name)
            {
          
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

          

            public string GetName()
            {
                return name;
            }


            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 150 ? age : -1;
            }
          

            public int GetAge()
            {
               return age; 
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }

        }

        static int x = 5;

        static void Main(string[] args)
        {
            

            Person person = new Person("AL", 23);            
            Console.WriteLine(person.ReturnDetails());

            x = 20;

            Console.ReadLine();
        }

        static void something(Person person)
        {
            x = 10;
        }

        







    }
}
