using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE2
{
    // Class Program
    // Author: ArcherLai
    // Purpose: Bug squashing exercise
    // Restrictions: None

    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None

        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0. Compile-time error. No semicolon at the end. If we have for loop, i = 0 is unnecessary.
            int i;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i). Logic error. i - 1 = 0, 0 cant be denominator
            for (i = 2; i < 10; ++i)
            {
                // declare string to hold all numbers. 
                // string allNumbers; Comopile-time error. 
                string allNumbers = "";

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); Compile time error. No parentheses for "i-1"
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                Console.WriteLine(i / (i - 1));

                // concatenate each number to allNumbers
                // allNumbers += i + " "; Run-time error. Unnecessary assigned 
                   allNumbers += i + " ";

                // increment the counter
                //i = i + 1; I think the counter is unnecessary
                

               // output all numbers which have been processed
               //Console.WriteLine("These numbers have been processed: " allNumbers);
               // Compile-time error. No plus quotation before variable.
                Console.WriteLine("These numbers have been processed: "+ allNumbers);
            }
           
        }

    }
}

