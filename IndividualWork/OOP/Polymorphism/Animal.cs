using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Polymorphism
{
    public class Animal
    {
        public Animal(string name)
        {
            Console.WriteLine(name);
        }
        public virtual void Move()
        {
            Console.WriteLine("Animals are moving");
        }
        public string Eat(string eat)
        {
            return eat;
        }
    }
}
