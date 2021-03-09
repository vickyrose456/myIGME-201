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

        //count: int r


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

    public class Dog : Pet, IDog
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

    interface IDog
    {
        //eat()
        void Eat();


        //play()
        void Play();
        

        //bark
        void Bark();
        

        //neddwalk
        void NeedWalk();

        //gotoVet
        void GotoVet();


    }//IDog


    public class Cat : Pet, ICat
    {
        //eat()
        public void Eat()
        {
            
        }
        //play()
        public void Play()
        {
            
        }
        //purr()
        public void Purr()
        {
            
        }
        //scratch
        public void Scratch()
        {
            
        }
        //gotoVet
        public void GotoVet()
        {
            
        }
        //()
        public Cat()
        {
            
        }

    }//cat

    interface ICat
    {
        //eat
        void Eat();
        //play
        void Play();
        //scratch
        void Scratch();
        //purr
        void Purr();

    }//iCat






}//petApp
