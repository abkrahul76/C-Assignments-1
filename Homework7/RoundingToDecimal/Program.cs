using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingToDecimal
{
    class Program
    {
        public static void Main(string[] args)
        {
            double number = 0;
            
            Console.WriteLine("{0}","Enter a decimal value");

            number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Orignal value entered by user :{0}", number);

            Console.WriteLine("value from method  RoundToInteger :{0}", RoundToInteger(number));

            Console.WriteLine("value from method  RoundToTenths :{0}", RoundToTenths(number));

            Console.WriteLine("value from method  RoundToHundredths :{0}", RoundToHundredths(number));

            Console.WriteLine("value from method  RoundToThousandths :{0}", RoundToThousandths(number));

            Console.ReadLine();

        }

        public static double RoundToInteger(double x) 
        {
            return Math.Floor(x);
        }

        public static double RoundToTenths(double x) 
        {
            return Math.Floor( x *10 + 0.5 ) /10 ;
        }

        public static double RoundToHundredths(double x) 
        {
            return Math.Floor( x *100 + 0.5 ) /100 ;
        }

        public static double RoundToThousandths(double x) 
        {
            return Math.Floor( x *1000 + 0.5 ) /1000 ;
        }

    }
}
