using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class CircleTest
    {
        static void Main(string[] args)
        {

            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(10);

            Console.WriteLine("Display info of circle1 is {0}",circle1.displayCircleInfo());
            Console.WriteLine("Display info of circle2 is {0}", circle2.displayCircleInfo());

            circle2.Radius = -5;

            Console.WriteLine("Display info of Changed circle2 is {0}", circle2.displayCircleInfo());

            Console.ReadLine();

        }
    }
}
