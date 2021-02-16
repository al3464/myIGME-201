using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE8
{       
        // Class Program
        // Author: ArcherLai
        // Purpose: PE8 questions
        // Restrictions: None
    public class Program
    {
        // Method: Main
        // Purpose: #5 #7 #8
        // Restrictions: None
        static void Main(string[] args)
        {   


            //Random rnd = new Random();
            //int x = rnd.Next(-1, 1);
            //int y = rnd.Next(1, 4);
            //int z = 3 * y * y + 2 * x - 1;
            //double[,,] formula = new double[x, y, z];
            //#5

            Console.WriteLine("Plz input a word.");
            string input = Console.ReadLine();
            int i = 0;
            i = input.Length - 1;
            while(i >= 0)
            {
                Console.WriteLine("The outout is: "+ input[i]);
                i--;
            }

            //#7
            Console.WriteLine("Could you input a sentence?");
            var response = "No";
            var newResponse = "Yes";
            var previousSentence = Console.ReadLine();
            var newSentence = previousSentence.Replace(response, newResponse);
            Console.WriteLine("oh! your output is:" + newSentence);
            //#8

            








        }
    }
}
