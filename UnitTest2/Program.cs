using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2
{
    
        public abstract class GamesPlay
        {
            string gameGenre;
            public abstract void Login();
        }

        public interface INintendo
           {
            void nintendo();

        }

        public interface ISteam
        {
            void steam();
        }

        public class Pokemon : INintendo
        {
            public int pixie;
            public virtual void nintendo()
            {
            Console.WriteLine("Welcome to Pokemon.");
            }
        }


        public class Pikachu : Pokemon
        { 
            public override void nintendo()
            {
            Console.WriteLine("Pikachu-------");
            }  
    
        }



        public class Csgo : ISteam
        {
            public int guns;
            public virtual void steam()
            {
                
            }
            
        }
    class Program
    {
        static void Main(string[] args)
        {
             void Call(Pokemon poke) 
             {
                poke.nintendo();
             }

           Pokemon pokemon = new Pokemon();
           Pikachu pikachu = new Pikachu();
            pokemon.nintendo();
            pikachu.nintendo();
             
        }

    }


    
}