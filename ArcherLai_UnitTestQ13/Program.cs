using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_UnitTestQ13
{
    class Program
    {  
        struct employee
        {
            public string sName;
            public double dSalary;
        }
        static void Main(string[] args)
        {
            employee employee1;
            employee1.sName = "Archer";
            employee1.dSalary = 30000;
            bool GiveRaise(employee employeeData)
            {
                
                if (employeeData.sName == "Archer")
                {
                    employee1.dSalary += 19999.99;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            GiveRaise(employee1);
            Console.WriteLine(employee1.sName);
            Console.WriteLine(employee1.dSalary);
            Console.ReadLine();
        }
    }
}
