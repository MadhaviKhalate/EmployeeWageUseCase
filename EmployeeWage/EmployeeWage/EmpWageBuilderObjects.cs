using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageBuilderObjects
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private String companyName;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObjects(string companyName, int empRatePerHr,
            int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;   
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void ComputeTotalEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
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
            totalEmpWage = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine("Total employee wage " + totalEmpWage);
            Console.WriteLine("Total employee wage for company " + this.companyName + " is: " + this.totalEmpWage);
        }
    }
}
