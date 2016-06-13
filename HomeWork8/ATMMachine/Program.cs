using System;

namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            Account[] accounts = new Account[10];

            for (int i = 0; i <= 9; i++)
            {
                accounts[0] = new Account(i, 100);

            }


            int selectedOption;

            int accountId;

            do
            {
                Console.WriteLine("Please enter the account id: ");

                accountId = Convert.ToInt32(Console.ReadLine());

                if (accountId >= 0 && accountId <= 9)
                {

                    do
                    {
                        Console.WriteLine("{0}\n   {1}\n   {2}\n   {3}\n   {4}\n",

                            "Please enter a choice:",
                            "1 for viewing the current balance",
                            "2 for withdrawing money",
                            "3 for depositing money",
                            "4 for exiting the main menu "

                         );

                        selectedOption = Convert.ToInt32(Console.ReadLine());



                        if (selectedOption != 4)
                        {
                            Console.WriteLine("Seleted Operation Successfull. \n");
                        }


                    } while (selectedOption != 4);
                }
                else
                {
                    Console.WriteLine("you have selected an invalid Id");
                }

            } while (true);

        }
    }
}
