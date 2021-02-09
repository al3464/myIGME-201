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
            Console.WriteLine("Input two numbers: ");
            int var1 = Console.Read();
            int var2 = Console.Read();

           
            bool operant = false;
            if (var1 > 10 && var2 > 10)
            {
                Console.WriteLine("Your input is: " + var1 + "," + var2);
                Console.WriteLine("Your input is worng", operant);
                Console.WriteLine("Input numbers again: ");
                Console.ReadLine();
                int var3 = Console.Read();
                int var4 = Console.Read();
                if(var3 < 10 && var4 < 10)
                {
                    Console.WriteLine("The numbers are: " + var3 + var4);
                }
            }else
            {
                Console.WriteLine("Your input is correct!", !operant);
                Console.WriteLine("Your input is: " + var1 + var2);
            }
            
         
           




        }
    }
}
