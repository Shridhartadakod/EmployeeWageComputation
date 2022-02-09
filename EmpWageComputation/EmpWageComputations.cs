using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
   public class EmpWageComputations
    {
        private const int IS_PRESENT = 1;
        /// <summary>
        /// determine whether employee is present
        /// </summary>
        public void ISEmployeePresent()
        {
            Random r = new Random();
            int check = r.Next(0, 2);
            if(check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                 Console.WriteLine("Employee is absent");
            
        }

    }
}
