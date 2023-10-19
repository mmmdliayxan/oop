using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Inheritance
{
    internal class EquilateralTriangle : RegularPolygon
    {
        public int side;
        public double Area(int length)
        {
            return (length * length * Math.Sqrt(3)) / 4;
        }
        public EquilateralTriangle(string name, int side) : base(name)
        {
            this.side = side;
            Console.WriteLine("Triangle has " + side + " sides");

        }
       
    }
}
