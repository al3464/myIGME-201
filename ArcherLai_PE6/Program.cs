using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE6
{       
        // Class: Main
        // Author: ArcherLai
        // Purpose: Design a guessing game
        // Restrictions: None
    class Program
    {   
            // Method:  parse and for and if statements
            // Purpose: Guess correct numbers
            //  strictions: None
            static void Main(string[] args)
        {
            Random rand = new Random();
            //set rand to random

            int randomNumber = rand.Next(0, 101);
            // generate a random number between 0 inclusive and 101 exclusive

            Console.WriteLine("The random number is: " + randomNumber);
            //Test the random Number
            
            for(int counter = 1; counter < 3; ++counter) //use for loop to set the counter
            {
                Console.WriteLine("Guess a number: ");
                //prompt the user to guess a number 

                int number = int.Parse(Console.ReadLine());
                //set parse to test if the number is valid

                if(number >= 101)
                {
                    Console.WriteLine("The number you guess is higher, plz try again!");
                   
                    continue;
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number you guess is lower, plz try again!");
                    continue;
                }
                else if(number == randomNumber)
                {
                    Console.WriteLine("The number is correct");
                    break;
                }
                else
                {
                    Console.WriteLine("The number you guess is valid but not correct, plz try again!");
                    continue;
                    
                }
                
            }
                Console.WriteLine("Thanks for trying! The number you want to guess is: " + randomNumber);
        }

        }
    }




