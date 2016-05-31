//product of odd integers from 1 to 7 using for loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {

            int product = 1;

            for (int i = 1; i <= 7; i+=2)
            {
                product = (product * i);
            }

            Console.WriteLine("Product of Odd Integers between 1 to 7 is: {0}", product);

            Console.ReadLine();
        }
    }
}
