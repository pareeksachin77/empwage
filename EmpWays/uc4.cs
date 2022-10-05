using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays
{
    internal class uc4
    {
        public static void empwage4()
        {
            const int  IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empwageperhour = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            int emphrs = 0;
            int empwage = 0;

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    emphrs = 8;
                    break;
                case IS_PART_TIME:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            empwage = emphrs * empwageperhour;
            Console.WriteLine("empwage is"+ empwage);
        }
    }
}
