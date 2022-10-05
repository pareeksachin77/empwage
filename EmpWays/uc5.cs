using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays
{
    internal class uc5
    {
        public static void empwage5()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empwageperhour = 20;
            int numofworkingdays = 20;
            int emphrs = 0;
            int empwage = 0;
            int totalemphrs = 0;
           

            for (int i = 0; i < numofworkingdays; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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

                totalemphrs += emphrs;
            }
            empwage = empwageperhour * totalemphrs;
            Console.WriteLine("total employee wage is" + empwage);



        }

    }
}
