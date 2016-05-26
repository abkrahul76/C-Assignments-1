using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            //create two instance of Employee class
            Employee emp1 = new Employee("Anupavan", "Muddana", 80000);

            Employee emp2 = new Employee("Pavan", "Bhatraju", 85000);

            Console.WriteLine("Yearly salary of {0} {1} is : {2}",
                              emp1.FirstName,
                              emp1.LastName,
                              emp1.Salary);

            Console.WriteLine("Yearly salary of {0} {1} is : {2}",
                  emp2.FirstName,
                  emp2.LastName,
                  emp2.Salary);

            emp1.Salary = (emp1.Salary * Convert.ToDecimal(1.1) );
            emp2.Salary = (emp2.Salary * Convert.ToDecimal(1.1));


            Console.WriteLine("Modified Yearly salary of {0} {1} is : {2}",
                  emp1.FirstName,
                  emp1.LastName,
                  emp1.Salary);

            Console.WriteLine("Modified Yearly salary of {0} {1} is : {2}",
                  emp2.FirstName,
                  emp2.LastName,
                  emp2.Salary);

            Console.ReadLine();

        }
    }
}
