using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        private double radius;

        public double Radius {

            get
            {
                return radius;
            }

            set
            {
                if(value >= 0)
                    radius = value;
            }
        
        }

        public Circle(double r)
        {
            Radius = r;
        }

        public double getArea()
        {
            return 3.14159 * radius * radius;
        }

        public double getDiameter()
        {
            return 2 * radius;
        }

        public string displayCircleInfo()
        {
            return String.Format("Radius : {0}   Diameter: {1}  Area: {2}", Radius, getDiameter(), getArea());
        }
    }
}
