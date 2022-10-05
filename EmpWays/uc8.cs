using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays
{
    internal class uc8
    {
        public static int empwage8(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            Console.WriteLine(company);
            const int FULL_TIME_HOUR = 1;
            const int PART_TIME_HOUR = 2;
            int empHrs = 0;
            int totalWorkinhours = 0;
            int totalWorkingdays =0;
            int empWage = 0; 
            while(totalWorkinhours <= maxHoursPerMonth && totalWorkingdays<numOfWorkingDays)
            {
                totalWorkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME_HOUR:
                        empHrs = 8;
                        break;
                    case PART_TIME_HOUR:
                        empHrs = 4;
                         break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkinhours+=empHrs; // tw = tw+ emphrs
                Console.WriteLine("Days: "+ totalWorkingdays + "Working Hours " + totalWorkinhours);
            }
            empWage = totalWorkinhours * empRatePerHour;
            Console.WriteLine("Total Employee Wage:" + empWage);
            return empWage;            
        }
    }
}
