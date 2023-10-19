using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Inheritance
{
    public class Square : RegularPolygon
    {
        public int side;
        public int Area(int length)
        {
            return length * length;
        }
        public Square(string name, int side) : base(name)
        {
            this.side = side;
            Console.WriteLine("Square has " + side + " sides");

        }
        

    }
}
