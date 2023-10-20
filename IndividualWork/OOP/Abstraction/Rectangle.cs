using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Abstraction
{
    public class Rectangle : Shape,Interface1
    {
        public Rectangle(double height,double width)
        {
            Height = height;
            Width = width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
        public string Name
        {
            get
            {
                return "Rectangle";
            }
        }
        public string Color(string  color)
        {
            return $"Rectangle is {color}";
        }




    }
}
