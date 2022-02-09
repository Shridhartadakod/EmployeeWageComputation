using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Emplyee Wage Computation");
            EmpWageComputations emp = new EmpWageComputations();
            emp.ISEmployeePresent();
            emp.CalculateEmpDaliyWage();
            emp.SwitchStatement();
            Console.ReadKey();
        }
    }
}
