using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE4Q2
{   
    // Class: Main
    // Author: ArcherLai
    // Purpose: Design an application
    // Restrictions: None
    class Program
    {
        // Method: if-else statement
        // Purpose: Q2
        //Restrictions: None
        static void Main(string[] args) 
        {
            int var1 = 0; 
            int var2 = 0;
            bool operant1 = false;
            bool operant2 = false;
            if (var1 < 10 && var2 < 10)
            {
                operant1 = false;
                operant2 = false;
            }else if(var1 > 10 && var2 < 10)
            {
                operant1 = true;
                operant2 = false;
            }else if (var1 < 10 && var2 > 10)
            {
                operant1 = false;
                operant2 = true;
            }
            else 
            {
                operant1 = true;
                operant2 = true;
            }
            
           



        }
    }
}
