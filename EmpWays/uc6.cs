using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays
{
    internal class uc6
    {
        public static void empwage6()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int wageperhour = 200;
            int maxnumofworkingdas = 20;
            int maxworkinghrs = 100;
            int totalworkinghrs = 0;
            int totalworkingdays = 0;
            int emphrs = 0;
            int empwage = 0;
            while(totalworkingdays<=maxnumofworkingdas && totalworkinghrs <= maxworkinghrs)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME:
                        emphrs = 8;
                        break;
                    case PART_TIME:
                        emphrs = 4;
                        break;
                    default: 
                        emphrs = 0;
                        break;
                }
                totalworkinghrs+= emphrs;
            }
            empwage = totalworkinghrs * wageperhour;
            Console.WriteLine("total empwage is"+ empwage);
        }
    }
}
