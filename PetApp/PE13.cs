using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetApp;

namespace pe13
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            //create list of pets
            Pets pets = new Pets();

            //random num
            Random rand = new Random();

            //loop 50 times
            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        //output you bought dog
                        Console.WriteLine("You bought a dog!");

                        //get input on name, license id and age
                        Console.WriteLine("Enter the Dog's name: ");
                        string dName = Console.ReadLine();

                        Console.WriteLine("Enter the Dog's license ID: ");
                        string id = Console.ReadLine();

                        Console.WriteLine("Enter the Dog's age: ");
                        int dAge = Convert.ToInt32(Console.ReadLine());

                        // add a dog
                        thisPet = new Dog(id, dName, dAge);
                        pets.Add(thisPet);
                    }
                    else
                    {
                        // else add a cat
                        //output bought cat
                        Console.WriteLine("You bought a cat!");

                        //get input of name and age
                        Console.WriteLine("Enter the Cat's name: ");
                        string cName = Console.ReadLine();

                        Console.WriteLine("Enter the Cat's age: ");
                        int cAge = Convert.ToInt32(Console.ReadLine());

                        //add cat
                        thisPet = new Cat(cName, cAge);
                        pets.Add(thisPet);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    //if no pets, go back to loop
                    Random nRand = new Random();

                    if (thisPet == null)
                    {
                        //continue through the loop
                        continue;
                    }
                    else
                    {
                        //if dog, 
                        if (thisPet.GetType() == typeof(Dog))
                        {
                            //set interface to dog
                            iDog = thisPet;
                        }
                        else if (thisPet.GetType() == typeof(Cat))
                        {
                            //set interface to cat
                            iCat = thisPet;
                        }
                    }
                }

            }


        }
    }
}
