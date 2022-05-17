using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeClass
    {
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;
        int EMP_RATE_PER_HRS = 20;
        int empHrs;
        int empWage;
       
        public bool checkStatus()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                return true;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                return false;
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
                empHrs = 0;
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
                    empHrs = 0;
                    break;
            }
            empWage = empHrs* EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage);
         }
    }
}
