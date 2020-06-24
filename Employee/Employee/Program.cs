using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeTest employee1 = new EmployeeTest("Bob", "Jones", 34500);
            EmployeeTest employee2 = new EmployeeTest("Susan", "Baker", 37809);

            Console.WriteLine("Employee 1: {0} {1}; Yearly Salary: {2:C2} ", employee1.FirstName, employee1.LastName, employee1.Salary);
            Console.WriteLine("Employee 2: {0} {1}; Yearly Salary: {2:C2} ", employee2.FirstName, employee2.LastName, employee2.Salary);
            Console.WriteLine();

            Console.WriteLine("Increasing employee salaries by 10%");
            employee1.Salary *= (decimal) 1.1;
            employee2.Salary *= (decimal) 1.1;
            Console.WriteLine("Employee 1: {0} {1}; Yearly Salary: {2:C2} ", employee1.FirstName, employee1.LastName, employee1.Salary);
            Console.WriteLine("Employee 2: {0} {1}; Yearly Salary: {2:C2} ", employee2.FirstName, employee2.LastName, employee2.Salary);

            Console.ReadLine();
        }
    }
}
