using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Abstraction
{
    public class Cone : Shape, Interface1
    {
        public Cone(double height, double radius)
        {
            Height = height;
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.Round(PI*Radius*(Radius*Height+Math.Sqrt(Math.Pow(Radius,2)+Math.Pow(Height,2))),2);
        }
        public string Name
        {
            get
            {
                return "Cone";
            }
        }
        public string Color(string color)
        {
            return $"Cone is {color}";
        }




    }
}
