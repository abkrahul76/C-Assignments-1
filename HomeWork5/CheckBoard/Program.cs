//method to print check board pattern
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoard
{
    class Program
    {
        static void Main(string[] args)
        {

            
           

            int noOfLines = 8;

            //syntinel loops -- run untill condition is met
            //loop with count control value 1
            while (noOfLines >= 1)
            {
                if (noOfLines % 2 == 0)
                {
                    Console.Write("* ");
                    Console.Write(" ");

                    Console.Write("* ");
                    Console.Write(" ");

                    Console.Write("* ");
                    Console.Write(" ");

                    Console.Write("* ");
                    Console.Write(" ");

                    Console.Write("* ");
                    Console.Write(" ");

                    Console.Write("* ");
                    Console.Write(" ");

                    Console.Write("* ");
                    Console.Write(" ");


                }
                else
                {
                    Console.Write(" ");
                    Console.Write("* ");

                    Console.Write(" ");
                    Console.Write("* ");


                    Console.Write(" ");
                    Console.Write("* ");


                    Console.Write(" ");
                    Console.Write("* ");


                    Console.Write(" ");
                    Console.Write("* ");


                    Console.Write(" ");
                    Console.Write("* ");


                    Console.Write(" ");
                    Console.Write("* ");



                }

                Console.WriteLine();

                noOfLines -= 1;

            }

            Console.ReadLine();

        }
    }
}
