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
       /* struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            } 
        }*/

        class Person
        {
            public string name;
            public int age;

            public Person()
            {
            }

            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }

            public Person(int age)
            {
                this.age = age;
                this.name = "";
            }


            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }


        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);

            Console.ReadLine();

        }

        


                    
       
        

    }
}
