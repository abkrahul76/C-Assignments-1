//Program to count number of positive, negative, zeroes from 5 numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvDotNetAssgnmnt
{
    class Count
    {
        // Main method begins execution of C# application
        public static void Main(string[] args)
        {
            int number1; // declare first number to compare
            int number2; // declare second number to compare
            int number3; // declare third number to compare
            int number4; // declare fourth number to compare
            int number5; // declare fifth number to compare

            int noOfZeros = 0;
            int noOfPositives = 0;
            int noOfNegatives = 0;

            // prompt user and read first number
            Console.WriteLine("***This App takes five inetgers as inputs***");

            // prompt user and read first number
            Console.WriteLine("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            // prompt user and read second number 
            Console.WriteLine("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            // prompt user and read third number
            Console.WriteLine("Enter first integer: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            // prompt user and read fourth number 
            Console.WriteLine("Enter second integer: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            // prompt user and read fifth number
            Console.WriteLine("Enter first integer: ");
            number5 = Convert.ToInt32(Console.ReadLine());

            //checking number1 positve or negative or zero
            if (number1 > 0)
            {
                noOfPositives = noOfPositives + 1;
            }

            if (number1 == 0)
            {
                noOfZeros = noOfZeros + 1;
            }

            if (number1 < 0)
            {
                noOfNegatives = noOfNegatives + 1;
            }


            //checking number2 positve or negative or zero
            if (number2 > 0)
            {
                noOfPositives = noOfPositives + 1;
            }

            if (number2 == 0)
            {
                noOfZeros = noOfZeros + 1;
            }

            if (number2 < 0)
            {
                noOfNegatives = noOfNegatives + 1;
            }



            //checking number3 positve or negative or zero
            if (number3 > 0)
            {
                noOfPositives = noOfPositives + 1;
            }

            if (number3 == 0)
            {
                noOfZeros = noOfZeros + 1;
            }

            if (number3 < 0)
            {
                noOfNegatives = noOfNegatives + 1;
            }



            //checking number4 positve or negative or zero
            if (number4 > 0)
            {
                noOfPositives = noOfPositives + 1;
            }

            if (number4 == 0)
            {
                noOfZeros = noOfZeros + 1;
            }

            if (number4 < 0)
            {
                noOfNegatives = noOfNegatives + 1;
            }

            //checking number5 positve or negative or zero
            if (number5 > 0)
            {
                noOfPositives = noOfPositives + 1;
            }

            if (number5 == 0)
            {
                noOfZeros = noOfZeros + 1;
            }

            if (number5 < 0)
            {
                noOfNegatives = noOfNegatives + 1;
            }

            //display the result
            Console.WriteLine("Number of Positive numbers : {0}", noOfPositives);

            Console.WriteLine("Number of Negative numbers : {0}", noOfNegatives);

            Console.WriteLine("Number of Zeroes : {0}", noOfZeros);

            Console.ReadLine();
        } // end Main
    }
}
