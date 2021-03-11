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
            for (int i = 0; i < 50; i ++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog

                    }
                    else
                    {
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
