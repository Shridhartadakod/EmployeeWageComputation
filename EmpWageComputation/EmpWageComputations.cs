using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
   public class EmpWageComputations
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int Emp_Rate_Per_Hour = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;
       
        Random r = new Random();
        /// <summary>
        /// determine whether employee is present
        /// </summary>
        public void ISEmployeePresent()
        {
            
            int check = r.Next(0, 2);
            if(check == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                 Console.WriteLine("Employee is absent");
            
        }
        public void CalculateEmpDaliyWage()
        {


            int EmpHrs = 0;
            int EmpWage = 0;
        
            int check = r.Next(0, 2);

            if (check == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                EmpHrs = 0;
            }
                EmpWage = EmpHrs * Emp_Rate_Per_Hour;
                Console.WriteLine("Therefore EmpWage is " + EmpWage);
          

         }

    }
}
