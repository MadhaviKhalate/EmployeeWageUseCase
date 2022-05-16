// See https://aka.ms/new-console-template for more information
using System;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeClass employee = new EmployeeClass();
            employee.checkStatus();
            employee.dailyWage();
            employee.addPartTimeWage();
        }
    }
}
