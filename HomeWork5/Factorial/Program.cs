using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int number; // declare first number 
            int factorial = 1;

            Console.Write("Enter a non negative number to calculate factorial: "); // prompt user 
            // read first number from user
            number = Convert.ToInt32(Console.ReadLine());

            //factorial logic
            while (number > 0)
            {
                factorial *= number;

                number -= 1;
            }


            Console.WriteLine("Factial of entered number is : {0}", factorial);

            Console.ReadLine();
        }
    }
}
