﻿using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            int nY; //compile-time error, no semicolon
            int nAnswer;

            Console.WriteLine("This program calculates x ^ y.");//compile-time error, no double quotation marks

            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine();
                Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));//logical error, sNumber not assigned

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY));//logical error, nX should be nY, must have a ! before int

            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY); 

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


        static int Power(int nBase, int nExponent)//logical error, no static bfore int Power
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            return returnVal;//logical error, returnVal should be return 
        }
    }
}

