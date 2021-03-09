using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherLai_PE13
{
    public class Pets
    {
        List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                    
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }

        }
        
        public int Count
        {
            get
            {
                return this.petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
            
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }
    public abstract class Pet
    {
       
        private string name;
        public int age;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Pet()
        {

        }
    }


    public class Cat : Pet, ICat
    {
        public Cat()
        {
           
        }
        public void intro()
        {
            Console.WriteLine("You bought a cat!");
        }
        public override void Eat()
        {
            Console.WriteLine("Where's that mouse...");
        }

        public override void Play()
        {
            Console.WriteLine("Yuck, I don't like that!");
        }

        public void Purr()
        {
            Console.WriteLine("purrrrrrrrrrrrrrrrrrrr..");
        }

        public void Scratch()
        {
            Console.WriteLine("Hiss!");
        }

        public override void GotoVet()
        {
            Console.WriteLine("Peeeeeeeeeeeeee----");
        }

    }
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
    }
    
    public class Dog : Pet, IDog
    {
        public string license;
        public void intro()
        {
            Console.WriteLine("You bought a dog!");
        }
        public override void Eat()
        {
            Console.WriteLine("Yummy, I will eat anything!");
        }

        public override void Play()
        {
            Console.WriteLine("Throw the ball, throw the ball!");
        }

        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }

        public void NeedWalk()
        {
            Console.WriteLine("Woof woof, I need to go out.");
        }

        public override void GotoVet()
        {
            Console.WriteLine("Whimper, whimper, no vet!");
        }
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }
    class Program
    {
        static void Main(string[] args)
        {          
            Pet thisPet = null;
            Dog dog = new Dog();
            Cat cat = new Cat();
            IDog iDog = null;
            ICat iCat = null;
            Pets pets = new Pets();
            Random rand = new Random();
            List<Pet> petList = new List<Pet>();
            petList<string, object> CatDogNameList = new petList<string, object>();
            // 1 in 10 chance of adding an animal
            for (int i = 0; i < 50; ++i) 
            {
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        dog.intro();
                        
                        Console.WriteLine("The dog's name is:"); 
                        string dogName = Console.ReadLine();
                        Console.WriteLine("Age?");
                        string dogAge = Console.ReadLine();
                        // add a dog
                    }
                    else
                    {
                        cat.intro();
                        Console.WriteLine("The cat's name is:");
                        string catName = Console.ReadLine();
                        // else add a cat
                    }
                }
                else
                {
                    
                    // choose a random pet from pets and choose a random activity for the pet to do
                }
            }
        }
    }
}


