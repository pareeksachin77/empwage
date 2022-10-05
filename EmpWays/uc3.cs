using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays
{
    internal class uc3
    {
        public static void empwage3()
        {
            int IF_FULL_TIME = 1;
            int IF_HALF_TIME = 2;
            int empwageperhour = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int empHrs = 0;
            int empwage = 0;
            if (empCheck == IF_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empCheck == IF_HALF_TIME){
                empHrs = 4;
            }
            //else
            //{
               // empHrs = 0;
            //}
            empwage = empwageperhour*empHrs;
            Console.WriteLine("Employee daily wage is" + empwage);
        }
    }
}
