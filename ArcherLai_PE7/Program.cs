using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE7
{
    // Class Program
    // Author: ArcherLai
    // Purpose: Make a mad libs game
    // Restrictions: follow the instructions

    class Program
    {
        // Method: Main
        // Purpose: To understand the string.replace() and split() method
        //          
        //          
        // Restrictions: None

        public static void Main(string[] args)
        {

            Console.WriteLine("Do you want to play Mad Libs?");//ask if you want to play this game

            string text = File.ReadAllText(@"c:\\templates\\MadLibsTemplate.txt");//read the txt file

            while (true)//set while method to do valid testing
            {
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "yes")
                {

                    Console.WriteLine("Ok lets go!");
                    break;

                }
                else if (yesOrNo == "no")
                {
                    Console.WriteLine("alright bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry your answer is invalid could you try again?");
                    continue;
                }
            }

            Console.WriteLine("What's your name?");//inset user's name
            string name = Console.ReadLine();

            Console.WriteLine("Okay, " + name + "! Could you choose a number between 1 to 6?");//ask what number they want to choose

            char[] delimiterChars = { '#' };
            string[] lines = text.Split(delimiterChars);//set split method

            for (int counter = 0; counter < 3; counter++)
            {
                {
                    string resultString = Console.ReadLine();

                    if (resultString == "1")
                    {
                        char[] Replace = { '{', '}' };
                        Console.WriteLine(lines[0].Replace('{', ' ').Replace('}', ' ').Replace('_', ' '));//replace the characters
                        break;
                    }
                    else if (resultString == "2")
                    {
                        Console.WriteLine(lines[1].Replace('{', ' ').Replace('}', ' ').Replace('_', ' '));
                        break;
                    }
                    else if (resultString == "3")
                    {
                        Console.WriteLine(lines[2].Replace('{', ' ').Replace('}', ' ').Replace('_', ' '));
                        break;
                    }
                    else if (resultString == "4")
                    {
                        Console.WriteLine(lines[3].Replace('{', ' ').Replace('}', ' ').Replace('_', ' '));
                        break;
                    }
                    else if (resultString == "5")
                    {
                        Console.WriteLine(lines[4].Replace('{', ' ').Replace('}', ' ').Replace('_', ' '));
                        break;
                    }
                    else if (resultString == "6")
                    {
                        Console.WriteLine(lines[5].Replace('{', ' ').Replace('}', ' ').Replace('_', ' '));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Come on, " + name + "Try harder!");
                        continue;
                    }
                }


            }
        }
    }
}

