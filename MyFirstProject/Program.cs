using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;


namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Dictionary<int, string> names = new Dictionary<int, string>
             {

                 //KeyValuePair
                 {1, "AL" },
                 {2, "Art" },
                 {3, "Arthur" },

              };

             for (int i = 0; i < names.Count; i++)
             {
                 KeyValuePair<int, string> pair = names.ElementAt(i);

                 Console.WriteLine($"{pair.Key} - {pair.Value}");
             }

             Console.WriteLine();

             foreach (KeyValuePair<int, string> item in names)
             {
                 Console.WriteLine($"{item.Key} - {item.Value}");
             }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "AL" },
                {"Science", "Art" }
            };


            //Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }


            if(teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }



            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
