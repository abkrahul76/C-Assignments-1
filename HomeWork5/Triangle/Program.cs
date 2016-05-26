//finding the giving triangle sides are valid
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int number1; // declare first number 
            int number2; // declare second number 
            int number3; // declare second number 



            Console.Write("Enter first integer: "); // prompt user 
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); // prompt user
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third integer: "); // prompt user
            // read third number from user
            number3 = Convert.ToInt32(Console.ReadLine());

            //condition to check valid triangle sides
            //S1 + s2 > S3,  s2 + s3 > s1, and s1 + s3 > s2
            if ((number1 + number2 > number3) && (number2 + number3 > number1) && (number3 + number1 > number2))
            {
                Console.WriteLine("Entered sides form a valid Triangle");
            }
            else
            {
                Console.WriteLine("Entered sides do not form a valid Triangle");
            }

            Console.ReadLine();
        }
    }
}
