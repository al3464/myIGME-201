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
            get { return this.name; }

            set { this.name = value; }
        }

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();
    }


    public class Cat : Pet, ICat
    {
        public Cat(string name, int age) : base(name, age)
        {

        }

        public void intro()
        {
            Console.WriteLine(Name + ": You bought a cat!");
        }
        public override void Eat()
        {
            Console.WriteLine(Name + ": Where's that mouse...");
        }

        public override void Play()
        {
            Console.WriteLine(Name + ": Yuck, I don't like that!");
        }

        public void Purr()
        {
            Console.WriteLine(Name + ": purrrrrrrrrrrrrrrrrrrr..");
        }

        public void Scratch()
        {
            Console.WriteLine(Name + ": Hiss!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(Name + ": Peeeeeeeeeeeeee----");
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

        public Dog(string license, string name, int age) : base(name, age)
        {

        }

        public void Intro()
        {
            Console.WriteLine("You bought a dog!");
        }
        public override void Eat()
        {
            Console.WriteLine(Name + ": Yummy, I will eat anything!");
        }

        public override void Play()
        {
            Console.WriteLine(Name + ": Throw the ball, throw the ball!");
        }

        public void Bark()
        {
            Console.WriteLine(Name + ": Woof woof!");
        }

        public void NeedWalk()
        {
            Console.WriteLine(Name + ": Woof woof, I need to go out.");
        }

        public override void GotoVet()
        {
            Console.WriteLine(Name + ": Whimper, whimper, no vet!");
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
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();

            // 1 in 10 chance of adding an animal
            for (int i = 0; i < 50; ++i)
            {
                thisPet = null;
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        pets.Add(new Dog("A license for this dog!", "Stupid", 3));
                        // add a dog

                    }
                    else
                    {
                        pets.Add(new Cat("AbaAba", 1));
                        // else add a cat
                    }
                }
                else
                {
                    //use switch method to randomize
                    thisPet = pets[rand.Next(0, pets.Count)];

                    if (thisPet == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (thisPet.GetType() == typeof(Cat))
                        {
                            iCat = (Cat)thisPet;
                            switch (rand.Next(1, 5))
                            {
                                case 1:

                                    iCat.Play();
                                    break;
                                case 2:
                                    iCat.Eat();
                                    break;
                                case 3:
                                    iCat.Purr();
                                    break;
                                case 4:
                                    iCat.Scratch();
                                    break;
                            }
                        }
                        else
                        {
                            iDog = (Dog)thisPet;
                            switch (rand.Next(1, 6))
                            {
                                case 1:
                                    iDog.Play();
                                    break;
                                case 2:
                                    iDog.Eat();
                                    break;
                                case 3:
                                    iDog.GotoVet();
                                    break;
                                case 4:
                                    iDog.Bark();
                                    break;
                                case 5:
                                    iDog.NeedWalk();
                                    break;
                            }
                        }

                    }
                    // choose a random pet from pets and choose a random activity for the pet to do

                }
            }

            Console.ReadLine();
        }
    }
}


