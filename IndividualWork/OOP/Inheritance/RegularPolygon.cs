using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork.OOP.Inheritance
{
    public class RegularPolygon
    {
        public string name;
        public RegularPolygon(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public int Perimetre(int length, int sides)
        {
            return length * sides;
        }

        public void SumofExteriorAngles()
        {
            Console.WriteLine("Sum of exterior angles of all polygons is equal to 360");
        }

        public static void SumofExteriorAngles(int angle)
        {
            Console.WriteLine("Sum of any Polygon's exterior angles = " + angle);
        }
    }
}
