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
                        // add a dog
                        pets[i] = dog.Add(nDog);
                    }
                    else
                    {
                        // else add a cat
                        Console.WriteLine("You bought a cat!");
                        //output bought cat
                        //get input of name and age
                        //add cat

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
