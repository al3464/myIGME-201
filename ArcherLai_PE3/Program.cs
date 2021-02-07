using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE3
{

    class Program
    {
        static void Main(string[] args)
        {
            string val;
            Console.WriteLine("Input from user: ");
            val = Console.ReadLine();

            // convert to integer
            int res = Convert.ToInt32(val);

            // display the line
            Console.WriteLine("Input = {0}", res);

        }
    }
}
