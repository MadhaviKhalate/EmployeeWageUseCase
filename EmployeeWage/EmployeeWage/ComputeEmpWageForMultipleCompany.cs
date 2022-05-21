using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class ComputeEmpWageForMultipleCompany
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        public void ComputeTotalEmpWage(string companyName, int empRatePerHr, 
            int numOfWorkingDays, int maxHrsPerMonth)
        {
            Console.WriteLine("Company is " + companyName);
            while (totalEmpHrs < maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is present full time");
                        empHrs = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee is present part time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + " " + "Employee Hours " + totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total employee wage " + totalEmpWage);
        }
    }
}
