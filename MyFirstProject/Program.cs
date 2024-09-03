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
            

            public Person(string name, int age) 
            {
                this.name = name;
                this.age = age;
                
            }

            public void SetName(string name)
            {
                /*if (!string.IsNullOrEmpty(name))
                {
                this.name = name;
                }
                else
                {
                    this.name = "Invalid name";
                }*/

                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            /*public string GetName()
            {
                return name;
            }*/

            public string GetName() => name;

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }

            public void SetAge(int age)
            {
                /*if (age >= 0 && age <= 150)
                {
                    this.age = age;
                }
                else
                {
                    this.age = -1;
                }*/
                //condition ? true : false
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            /*public int GetAge()
            {
                return age;
            }*/

            public int GetAge() => age;

        }

        static void Main(string[] args)
        {
            Person person = new Person("AL", 23);            
            Console.WriteLine(person.ReturnDetails());

            //person.name = "Art";
            //person.age = 21;

            person.SetName("Art");
            person.SetAge(21);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.GetName()} amd your age is {person.GetAge()}");
            

            Console.ReadLine();
        }

        







    }
}
