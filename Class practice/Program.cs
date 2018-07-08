using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Spotty", 19, 0.7f);
            dog.print();

            Console.WriteLine();

            Animal cat = new Animal("Pat", 19, 0.5f);
            cat.print();

            Console.WriteLine();
            Console.WriteLine("Total number of animals: " + Animal.Count);
            Console.ReadLine();
        }
    }
}
