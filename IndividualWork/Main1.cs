using IndividualWork.OOP.Inheritance;
using IndividualWork.OOP.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork
{
    internal class Main1
    {
        static void Main(string[] args)
        {
            /*Inheritance*/

            Square square = new Square("Square", 4);
            Console.WriteLine(square.Perimetre(4, 12));
            Console.WriteLine(square.Area(12));

            EquilateralTriangle triangle = new EquilateralTriangle("Triangle", 3);
            Console.WriteLine(triangle.Perimetre(3, 12));
            Console.WriteLine(Math.Round(triangle.Area(3), 3));

            RegularPolygon regularPolygon = new RegularPolygon("Square");
            regularPolygon.SumofExteriorAngles();

            RegularPolygon.SumofExteriorAngles(360);

            Console.WriteLine("---------------------------------------------------------------");
            /*Polymorphism*/

            Animal[] animals= new Animal[3];
                animals[0] = new Animal("Animals");
                animals[1] = new Dog("Toplan", "Hav-hav");
                animals[2] = new Cat("Mestan");
            Console.WriteLine(animals[0].Eat("meat"));
            Dog dog = new Dog("Toplan", "Hav-hav");
            dog.Eat("meat","Toplan");
            Cat cat = new Cat("Mestan");
            cat.Eat(2, "cheese");
             foreach (var animal in animals)
            {
                animal.Move(); 
            }
            

        }
    }
}
