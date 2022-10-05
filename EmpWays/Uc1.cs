using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWays 
{
    internal class uc1
    {
        public void empwage1()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("absent");
            }
        }
}

}