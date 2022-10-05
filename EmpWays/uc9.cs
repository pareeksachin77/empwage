using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays
{
    internal class uc9
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int maxNumberOfWorkingDays;
        private int maxHoursPermonth;
        private int totalEmpwage;

        public uc9(string company, int empRatePerHour, int maxNumberOfWorkingDays, int maxHoursPermonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxNumberOfWorkingDays = maxNumberOfWorkingDays;
            this.maxHoursPermonth = maxHoursPermonth;
        }
        public void computeWage()
        {
            int empHrs = 0; int totalWorkingDays = 0; int totalEmpHrs = 0;
            
        while(empHrs <= this.maxHoursPermonth && totalWorkingDays< this.maxNumberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days :" + totalWorkingDays + "Total Working Hours: " + totalEmpHrs);
            }
            totalEmpwage = totalEmpHrs * this.empRatePerHour;

        Console.WriteLine("Total empwage for company" + company + "is " + totalEmpwage);
        }
        public string toString()
        {
            return "Total empwage for company" + this.company + "is :" + this.totalEmpwage;
        }
    }
}
