using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavColNum
{
    // Class: Main
    // Author:
    //Purpose: 
    //Restrictions: None
    static class Program
    {       
            //Method:
            //Purpose: Prompt the user for their favorite color and number.
            //         Output their favorite color (in limited text colors) their fav number of tiems
            // Restrictions: None
        static void Main(string[] args)
        {
            // Prompt the user for fav color
            string color = "null";
            string colorHouse = "green";
        
            int favNum = 0;
            
            // read color from the keyboard

            // prompt the user for fav number 
            Console.WriteLine("Enter your favorite color:\t");

            //read color from the keyboard
            color = Console.ReadLine();

            // read number from the keyboard
            favNum = Convert.ToInt32(Console.ReadLine());

            
            // change the text color to their favorite color
            switch(color.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }

            //loop to output their fav color their fav number of times
            for(int i = 0; i < favNum; ++i)
            {
                Console.WriteLine("Your favorite color is {0}. You fav number is {1}", color, favNum);
            }
       
        

        }
    }
}
