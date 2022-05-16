using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeClass
    {
        Random rand = new Random();
        public bool checkStatus()
        {
            int isFullTime = 1;
            int randomValue = rand.Next(0, 2);
            if (randomValue == isFullTime)
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
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HRS = 20;
            int empHrs;
            int empWage;

            int empCheck = Convert.ToInt32(checkStatus());
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage);

        }

        public void addPartTimeWage()
        {

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HRS = 20;
            int empHrs;
            int empWage;

            int empCheck = rand.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else
                empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage);
        }
    }
}
