using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE14Q1
{
    public class Cat
    {
        public void Mew()
        {
            Console.WriteLine("Meowwwwwww-----");
        }

    }

    public class CatsFood : Cat, IPets
    {
        public void Food()
        {
            Console.WriteLine("I want fish!!!");
        }
    }

    public interface IPets
    {
        void Food();
        void Mew();

       
    }
    class Program
    {
        public static void MyMethod(object myObject)
        {
            myObject.GetType();
            Cat myCat = new Cat();
            myCat.Mew();
        }

        static void Main(string[] args)
        {
           
        }
    }
}
