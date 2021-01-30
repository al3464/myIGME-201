using System;

namespace ArcherLai_PE1
{
    // Class: Main
    // Author: ArcherLai
    // Purpose: Be familiar with C#, create some variables and try out loops and statements.
    // Restrictions: None
    static class Program
        {       
                // Method: while loop, for loop, if statements
                // Purpose: Print some calculation results, try out loops method and if statements
                //Restrictions: None
        static void Main(string[] args)
        {
            //To say Hi I am Archer
            Console.WriteLine("Hi I am Archer!");

            //Create some variables
            int cat;
            string catFood; 

            //Do some math calculations
            int number = 7;
            number += 10;

            //Print the result
            Console.WriteLine(number);
            Console.WriteLine(Math.Sqrt(225));

            //See if implicit and explicit casting works the same way
            float theFloat = 10;
            double theDouble = 10;
            Console.WriteLine("theFloat: " + theFloat);
            Console.WriteLine("theDouble: " + theDouble);
            theDouble = (double)theFloat;
            Console.WriteLine("double: " + theDouble);

            //try out for loop
            for (cat = 5; cat < 10; cat = cat + 1)
            {
                Console.WriteLine("Number of cats: ");
                Console.WriteLine(cat);
            }

            //try out if statements
            Console.WriteLine("Press a key: ");
            char c = (char)Console.Read();
            if(char.IsLower(c))
            {
                Console.WriteLine("Cat is cute.");
            }
            else if(char.IsUpper(c))
            {
                Console.WriteLine("Cat eats cat food.");
            }
            else
            {
                Console.WriteLine("I have a cat.");
            }

            //try out while loop
            int catTree = 5;
            while(catTree < 10)
            {
                catTree++;
                Console.WriteLine("catTree: ");
                Console.WriteLine(catTree);
            }
        }
    }
}
