using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Polymorphism
{
    internal class Cat:Animal
    {
        public string Name;
        public Cat(string name):base(name)
        {
            Name = name;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"Cat {Name} is moving");
        }
        public void Eat(int number,string eat)
        {
            Console.WriteLine($"{Name} wants to eat {number} slices of  {eat}");
        }
    }
}
