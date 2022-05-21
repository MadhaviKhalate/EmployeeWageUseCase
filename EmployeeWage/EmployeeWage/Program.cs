// See https://aka.ms/new-console-template for more information
using System;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string companyName;
            int option, empRatePerHr, maxHrsPerMonth, numOfWorkingDays;

            Console.WriteLine("1.Calculate Employee Wage For Single Company" +
                "\n2.Enter Employee Wage For Multiple Company");
            Console.WriteLine("Enter Your Option");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    EmployeeClass employee = new EmployeeClass();
                    employee.checkStatus();
                    employee.dailyWage();
                    employee.addPartTimeWage();
                    employee.EmpWageUsingSwitch();
                    employee.calculateMonthlyWage();
                    employee.calculateTotalEmpWage();
                    break;
                case 2:
                    Console.WriteLine("Enter company name for Calculating total emplyoee wage");
                    companyName = Console.ReadLine();
                    Console.WriteLine("Enter employee rate per hour");
                    empRatePerHr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Maximum Hours Per Month");
                    maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of working days");
                    numOfWorkingDays = Convert.ToInt32(Console.ReadLine());
                    ComputeEmpWageForMultipleCompany company1 = new ComputeEmpWageForMultipleCompany();
                    company1.ComputeTotalEmpWage(companyName, empRatePerHr, numOfWorkingDays, maxHrsPerMonth);
                    ComputeEmpWageForMultipleCompany company2 = new ComputeEmpWageForMultipleCompany();
                    company2.ComputeTotalEmpWage(companyName, empRatePerHr, numOfWorkingDays, maxHrsPerMonth);
                    break;

            }
        }
    }
}
