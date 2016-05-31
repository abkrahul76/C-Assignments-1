using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingSales
{
    class Program
    {
        static void Main(string[] args)
        {
  
            int productNum;
            int quantity = 1;
            double totalSale = 0;


            do
            {
                Console.WriteLine("{0}\n{1}",
                    "Enter product number(1 or 2 or 3) and Quantity",
                    "Enter -1 to exit"
                    );

                productNum = Convert.ToInt32(Console.ReadLine());

                if (productNum != -1)
                   quantity = Convert.ToInt32(Console.ReadLine());

                totalSale = totalSale + Getprice(productNum) * quantity;

            } while (productNum!=-1);

            Console.WriteLine("Total retail vale of products sold : {0:C}",totalSale);

            Console.ReadLine();
        }

        static double Getprice(int productNum)
        {
            double price = 0;

            switch (productNum)
            {

                case 1:
                    price = 2.98;
                    break;
                case 2:
                    price = 4.50;
                    break;
                case 3:
                    price = 9.98;
                    break;
                default:
                    break;

            }

            return price;

        }
    }
}
