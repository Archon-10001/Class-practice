using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Animal
    {
        //Class vaiables
        public static int Count;
        public static string name;
        public static int age;
        public static float happiness;

        //Class constructors
        public Animal(string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;
            Count++;
        }
        //Class methods
        public void print()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("age " + age);
            Console.WriteLine("Happiness" + happiness);
        }

    }
}
