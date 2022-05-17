using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeClass
    {
        int IS_FULL_TIME = 1, IS_PART_TIME = 2,
            EMP_RATE_PER_HRS = 20, NUM_OF_WORKING_DAYS = 10, 
            empHrs = 0, empWage=0, totalEmpWage = 0 ;
        public void checkStatus()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
        public void dailyWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage);

        }

        public void addPartTimeWage()
        {

            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present full time");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is present part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage);
        }

        public void EmpWageUsingSwitch()
        {
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
            empWage = empHrs* EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage);
         }

        public void calculateMonthlyWage()
        {
            for (int days = 0; days < NUM_OF_WORKING_DAYS; days++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HRS;
                totalEmpWage += empWage;
                Console.WriteLine("Daily employee wage " + empWage);
            }
            Console.WriteLine("Total employee wage for month " + totalEmpWage);
        }

    }
}
