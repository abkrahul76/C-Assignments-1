//create the employee class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    //class declaration
    class Employee
    {
        //propert to store firstName
        public string FirstName { get; set; }

        //propert to store LastName
        public string LastName { get; set; }

        private decimal salary;

        //property to store Salary
        public decimal Salary {

            get
            {
                return salary;
            }

            set
            {
                //set the salary only if value is positive
                if (value >= 0)
                {
                    salary = value;
                }
            }
        
        }

        public Employee(string fname, string lname, double money)
        {
            FirstName = fname;
            LastName = lname;
            Salary = Convert.ToDecimal(money);
        }

    }
}
