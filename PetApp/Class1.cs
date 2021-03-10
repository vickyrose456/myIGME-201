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
        private int Count
        {
            //get returns petList.Count
            get 
            {
                return petList.Count();
            }
        }


        //Add(pet Pet)
        public void Add(Pet pet)
        {
            //should call petList.Add(pet)
            petList.Add(pet);
        }

        //remove(Pet pet)
        public void Remove(Pet pet)
        {
            //call petList.remove
            petList.Remove(pet);
        }

        //RemoveAt (petEI:int)
        public void RemoveAt(int petEI)
        {
            petList.RemoveAt(petEI);
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
        public abstract void Eat();

        //Play(): a
        public abstract void Play();

        //GotoVet():a
        public abstract void GotoVet();

        //()
        public Pet()
        {

        }//pet()

        //(name: string, age:int)
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


    }//Pet

    public class Dog : Pet, IDog
    {
        //license:string
        public string license;

        public Dog()
        {
            
        }

        //Eat()
        public override void Eat()
        {
            
        }//eat

        //play()
        public override void Play()
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
        public override void GotoVet()
        {
            
        }//gotoVet 


        //(szLicense:string, szName:string, nAge:int): base(szName, nAge)
        public Dog(string szLicense, string szName, int nAge) : base (szName, nAge)
        {
            this.Name = szName;
            this.age = nAge;
            this.license = szLicense;
        }


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
        public override void Eat()
        {
            
        }
        //play()
        public override void Play()
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
        public override void GotoVet()
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
