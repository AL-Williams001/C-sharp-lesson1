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


            // Auto property used for just getting and setting and no additional logic
           /* public string Name { get; set; }
            public int Age { get; set; }*/


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

            //public string Name { get => name; set => name = value; }

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

            //public int Age { get => age; set => age = value; }
           
            

            public Person(string name, int age) 
            {
               
                Name = name;
                Age = age;

            }

            /*public void SetName(string name)
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
            }*/

            public string ReturnDetails()
            {
                return $"Name: {Name}\nAge: {Age}";
            }

        }

       

        static void Main(string[] args)
        {
            

            Person person = new Person("AL", 23);            
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Art";
            person.Age = 21;


            //Console.WriteLine(person.ReturnDetails());


            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");

            Console.ReadLine();
        }

        







    }
}
