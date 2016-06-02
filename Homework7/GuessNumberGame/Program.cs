using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Y";

            do
            {
                Rungame();

                Console.WriteLine("Would you like to play again ! press Y  to play again or press Enter to exit");

                x = Convert.ToString(Console.ReadLine());

            } while (x == "y" || x == "Y");
        }

        static void Rungame()
        {

            Random randomNumbers = new Random();

            int chosenNumber = randomNumbers.Next(1, 1000);

            int selectedNumber = 0;

            int noOfGuesses = 0;

            do
            {
                Console.WriteLine("Enter the number you guessed (between 1 to 1000):");

                selectedNumber = Convert.ToInt32(Console.ReadLine());

                noOfGuesses++;

                if (selectedNumber > chosenNumber)
                {
                    Console.WriteLine("Too high. Try again");
                }
                else if (selectedNumber < chosenNumber)
                {
                    Console.WriteLine("Too Low. Try again");
                }
                else
                {
                    Console.WriteLine("Congratulations. You guessed the number!");

                    if (noOfGuesses > 10)
                    {
                        Console.WriteLine("You should be able to do better!");
                    }
                    else if (noOfGuesses < 10)
                    {
                        Console.WriteLine("Either you know the secret or you got lucky! ");
                    }
                    else
                    {
                        Console.WriteLine("Aha! You know the secret!");

                    }

                    break;
                }


            } while (true);


        }
    }
}
