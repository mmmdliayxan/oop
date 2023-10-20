using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Abstraction
{ 
        public abstract class Shape
        {
            public double Height;
            public double Width;
            public double Radius;
            public const float PI = 3.14f;
            public abstract double GetArea();
        }

    
}
