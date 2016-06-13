using System;

namespace AirlineReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[] seats = new[] { true, false, false, false, false, false, false, false, false, false, false };

            int selectedType;

            int nextAvailableEconomySeat = 6;

            int nextAvailableFCSeat = 1;


            do
            {
                //display messages to user for selection
                Console.WriteLine("{0}\n    {1}\n    {2}", "Please type:", "1 for First Class and Please type ", "2 for Economy", "-1 to Quit");

                selectedType = Convert.ToInt32(Console.ReadLine());

                if (selectedType == 1)
                {

                    if (nextAvailableFCSeat <= 5)
                    {
                        seats[nextAvailableFCSeat] = true;

                        Console.WriteLine("First Class Seat {0} Assigned.", nextAvailableFCSeat);

                        nextAvailableFCSeat++;
                    }
                    else
                    {
                        Console.WriteLine("Currently we do not have any available tickets. Next flight leaves in 3 hours");
                    }



                }
                else if (selectedType == 2)
                {
                    if (nextAvailableEconomySeat <= 10)
                    {

                        seats[nextAvailableEconomySeat] = true;

                        Console.WriteLine("Economy Seat {0} Assigned.", nextAvailableEconomySeat);

                        nextAvailableEconomySeat++;
                    }
                    else
                    {
                        Console.WriteLine("Currently we do not have any availble seats in Economy. Would you like to be assigned seat in FirstClass. ");

                        Console.WriteLine("Press Y to assign a first class ticket or N to opt-out");

                        if (Console.ReadLine().ToUpper().Equals("Y"))
                        {

                            if (nextAvailableFCSeat <= 5)
                            {
                                seats[nextAvailableFCSeat] = true;

                                Console.WriteLine("First Class Seat {0} Assigned.", nextAvailableFCSeat);

                                nextAvailableFCSeat++;
                            }
                            else
                            {
                                Console.WriteLine("Currently we do not have any available tickets. Next flight leaves in 3 hours");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Currently we do not have any available tickets. Next flight leaves in 3 hours");

                            break;
                        }
                    }
                }



            } while (selectedType != -1);



            Console.ReadLine();
        }


    }
}
