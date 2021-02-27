using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_UnitTestOneQ12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                string sName;
                double dSalary = 30000;
                sName = Console.ReadLine();
                
                bool GiveRaise(string name, ref double salary)
                {

                    if (name == "Archer")
                    {
                        salary += 19999.99;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            GiveRaise(sName, ref dSalary); 
            Console.WriteLine(dSalary);
            Console.ReadLine();
            
                
        
        }
        
    }
    
}

