using System;

namespace Day_9_EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Day_9_EmployeeWage.EmployeeClass obj1 = new Day_9_EmployeeWage.EmployeeClass();
            obj1.CompanyEmpWage("Wipro", 57, 27, 100);
            obj1.CompanyEmpWage("TCS", 77, 30, 150);
        }
    }
}
