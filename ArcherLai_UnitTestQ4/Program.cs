using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ArcherLai_UnitTestOne
{
    
    class Program
    {
        private static Timer time;
        public static string numbers;

        private static void FiveSecond()
        {
            time = new Timer();
            time.Interval = 5000;
            time.Elapsed += OnTimeEvent;
            time.Start();
        }

        private static void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            GiveAnswer(numbers);
        }

        private static void GiveAnswer(string numbers)
        {
            switch (numbers)
            {
                case "1":
                    Console.WriteLine("Time is up!");
                    Console.WriteLine("black");
                    time.Stop();
                    break;

                case "2":
                    Console.WriteLine("Time is up!");
                    Console.WriteLine("42");
                    time.Stop();
                    break;

                case "3":
                    Console.WriteLine("Time is up!");
                    Console.WriteLine("What do you mean? African or European swallow?");
                    time.Stop();
                    
                    break;
            }

            
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose your question (1-3): ");
                numbers = Console.ReadLine();
                Console.WriteLine("You have 5 seconds to answer the following question:");
                
                if (numbers == "1")
                {
                    Console.WriteLine("What is your favorite color?");
                    FiveSecond();

                    string colors = Console.ReadLine();
                    if (colors == "black")
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: black");
                    }
                }
                else if (numbers == "2")
                {
                    Console.WriteLine("What is the answer to life, the universe and everything?");
                    FiveSecond();

                    string number = Console.ReadLine();

                    if (number == "42")
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: 42");
                    }

                }
                else if (numbers == "3")
                {
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow ?");
                    FiveSecond();

                    string mean = Console.ReadLine();
                    if (mean == "What do you mean? African or European swallow?")
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: What do you mean? African or European swallow ?");
                    }
                }

                Console.WriteLine("Play again?");
                string yesOrno = Console.ReadLine();
                if (yesOrno == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }                      
        }
    }
}
