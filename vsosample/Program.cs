using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsosample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Matsumura" };
            Console.WriteLine(person.SayName());
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string SayName()
        {
            return Name;
        }
    }
}
