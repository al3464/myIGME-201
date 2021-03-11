using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE14Q1
{
    interface IPets
    {
        void PetsFood();
       
    }

    public class Dog : IPets
    {
        public Dog()
        {
            
        }
        public void PetsFood()
        {
            Console.WriteLine("Meat!!!");
        }
    }

    public class Cat : IPets
    {
 
        public void PetsFood()
        {
            Console.WriteLine("Fish!!!");
        }
      
    }
   
    class Program
    {
        public static void MyMethod(object myObject)
        {
            var pets = myObject as Cat;
            if(pets != null)
            {
                pets.PetsFood();
            }
            else
            {
                var pet = myObject as Dog;
                if(pet != null)
                {
                    pet.PetsFood();
                }
                else
                {
                    Console.WriteLine("Not cat and not dog.");
                }
            }
            
        }

        static void Main(string[] args)
        {
            Cat cats = new Cat();
            Dog dogs = new Dog();
            MyMethod(cats);
            MyMethod(dogs);
        }
    }
}
