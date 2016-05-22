//Program to calculate BMI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double heightInMeters; // declare height variable
            double weightInKgs; // declare weight variable

            double bmi;

            // prompt user and read height
            Console.WriteLine("Enter your height in meters: ");
            heightInMeters = Convert.ToDouble(Console.ReadLine());

            // prompt user and read weight 
            Console.WriteLine("Enter your weight in Kilograms: ");
            weightInKgs = Convert.ToDouble(Console.ReadLine());

            //bmi calculation BMI= weightInKilograms / (heightInMeters × heightInMeters)

            bmi = weightInKgs / (heightInMeters * heightInMeters);

            //display bmi value to user
            Console.WriteLine("your BMI is : {0}",bmi);


            //display bmi criteria to user
            Console.WriteLine("BMI VALUES");
            Console.WriteLine("----------");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal: between 18.5 and 24.9");
            Console.WriteLine("Overweight: between 25 and 29.9");
            Console.WriteLine("Obese: 30 or greater");

            Console.ReadLine();
        }
    }
}
