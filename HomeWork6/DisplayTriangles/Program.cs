using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            //for printing diagram 1

            //Console.WriteLine("(a)");

            int noOfStarsD1 = 1;

            for (int i = 1; i <= 10; i++)
            {

                for (int k = 1; k <= noOfStarsD1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                noOfStarsD1++;
            }

            Console.WriteLine();

            //for printing diagram 2

            //Console.WriteLine("(b)");

            int noOfStarsD2 = 10;

            for (int i = 1; i <= 10; i++)
            {

                for (int k = 1; k <= noOfStarsD2; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                noOfStarsD2--;
            }

            Console.WriteLine();

            //for printing diagram 3

            //Console.WriteLine("(c)");

            int noOfStarsD3 = 10;
            int noOfspacesD3 = 0;

            for (int i = 1; i <= 10; i++)
            {

                for (int k = 1; k <= noOfspacesD3; k++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= noOfStarsD3; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                noOfspacesD3++;
                noOfStarsD3--;
            }

            Console.WriteLine();

            //for printing diagram 4

            //Console.WriteLine("(d)");

            int noOfStarsD4 = 1;
            int noOfspacesD4 = 10;

            for (int i = 1; i <= 10; i++)
            {

                for (int k = 1; k <= noOfspacesD4; k++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= noOfStarsD4; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                noOfspacesD4--;
                noOfStarsD4++;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
