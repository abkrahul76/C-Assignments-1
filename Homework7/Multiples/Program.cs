using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            
            Console.WriteLine("{0}", "Enter a pair of integers" );

            number1 = Convert.ToInt32(Console.ReadLine());

            number2 = Convert.ToInt32(Console.ReadLine());

            bool isMultiple = Multiples(number1,number2);

            if (isMultiple)
                Console.WriteLine("Second integer is a multiple of first integer");
            else
                Console.WriteLine("Second integer is NOT a multiple of first integer");

            Console.ReadLine();

        }

        public static bool Multiples(int number1, int number2)
        {

            return ((number2 % number1) == 0) ? true : false;

        }

        
    }
}
