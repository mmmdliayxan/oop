using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Polymorphism
{
    public class Dog:Animal
    {
        public string Name;
        public string Voice;
        public Dog(string name,string voice) : base(name)
        {
            Name = name;
            Voice = voice;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"Dog {Name} is moving");

        }
        public void Eat(string eat,string name)
        {
            Console.WriteLine($"{Name} wants to eat {eat}");
        }
    }
}
