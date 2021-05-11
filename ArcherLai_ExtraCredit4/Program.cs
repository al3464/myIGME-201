using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Recursion
    {
        /// <summary>
        ///  Program class to demonstrate simple recursion
        ///  Author: David Schuh
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence to build a tree from: ");
            string myString = Console.ReadLine();

            BuildTree(ref myString);
        }

        static void BuildTree(ref string str)
        {
            // function to recursively output a string with the first letter successively removed

            Console.WriteLine(str);

            // if we still have more than one character in the string
            if (str.Length > 1)
            {
                // create new string with first letter removed
                string subStr = str.Substring(1, str.Length - 1);

                // call myself again to do the same
                BuildTree(ref subStr);
            }
        }
    }
}
