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


            


            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
                }
            }

            

            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value >= 0 && value <= 150 ? value : -1;
                }
            }

           
           
            

            public Person(string name, int age) 
            {
               
                Name = name;
                Age = age;

            }

            

            /*public string ReturnDetails()
            {
                return $"Name: {Name}\tAge: {Age}";
            }*/

            public override string ToString()
            {
                return $"Name: {Name}\tAge: {Age}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Person)
                {
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
                }

                return false;
                
            }




        }

       

        static void Main(string[] args)
        {
            

            Person person = new Person("AL", 23);
            Person test = new Person("AL", 23);
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
           

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not the same");
            }




            Console.ReadLine();
        }

        







    }
}
