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
                "\n2.Calculate Employee Wage For Multiple Company \n3.Calculate Total Employee Wage ");
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
                    ComputeEmpWageForMultipleCompany company1 = new ComputeEmpWageForMultipleCompany();
                    company1.ComputeTotalEmpWage("Reliance", 20, 4, 10);
                    ComputeEmpWageForMultipleCompany company2 = new ComputeEmpWageForMultipleCompany();
                    company2.ComputeTotalEmpWage("TCS", 20, 8, 20);
                    break;

                case 3:
                    EmpWageBuilderObjects object1 = new EmpWageBuilderObjects("Wipro", 20, 8, 10);
                    object1.ComputeTotalEmpWage();
                    EmpWageBuilderObjects object2 = new EmpWageBuilderObjects("Infosys", 40, 10, 20);
                    object2.ComputeTotalEmpWage();
                    break;
            }
        }
    }
}
