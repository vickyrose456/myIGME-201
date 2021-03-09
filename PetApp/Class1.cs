using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public class Pets
    {
        //pet list
        List<Pet> petList = new List<Pet>();

        //count int r


        //this int petEI
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
        }//this Pet

        //Add(pet Pet)
        public void Add(Pet pet)
        {

        }

        //remove(Pet pet)
        public void Remove(Pet pet)
        {

        }

        //RemoveAt (petEI:int)
        public void RemoveAt(int petEI)
        {

        }


    }

    public class Pet : Pets
    {
        //name:string
        private string name;

        //age:int
        public int age;

        //Name: string
        public string Name;

        //Eat(): a

        //Play(): a

        //GotoVet():a

        //()
        public Pet()
        {

        }//pet()

        //(name: string, age:int)
        public Pet(string name, int age)
        {

        }


    }//Pet

    public class Dog : Pet
    {
        //license:string
        public string license;

        //Eat()
        public void Eat()
        {
            
        }//eat

        //play()
        public void Play()
        {
            
        }//play


        //Bark()
        public void Bark()
        {
            
        }//bark

        //needWalk()
        public void NeedWalk()
        {
            
        }//needwalk

        //GotoVet
        public void GotoVet()
        {
            
        }//gotoVet 


        //(szLicense:string, szName:string, nAge:int): base(szName, nAge)

    }//Dog

    public class IDog
    {
        //eat()
        public void Eat()
        {
            
        }

        //play()
        public void Play()
        {
            
        }

        //bark
        public void Bark()
        {
            
        }

        //neddwalk
        public void NeedWalk()
        {
            
        }

        //gotoVet
        public void GotoVet()
        {
            
        }


    }//IDog



}//petApp
