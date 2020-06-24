using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Employee
{
    class EmployeeTest    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }
        public EmployeeTest(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }       
    }
}

