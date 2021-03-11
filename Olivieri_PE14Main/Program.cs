using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classy;

namespace Main_PE14
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //declare obj of each class
            myAClass myClass = null;
            my1stClass class1 = new my1stClass();
            my2ndClass class2 = new my2ndClass();
            //myInterface myIntface = null;

            myMethod(class1);
            myMethod(class2);
            myMethod(myClass);
        }
        //method called myMethod that passes in an object
        public static void myMethod(object myObject)
        {
            //interface ref variable
            myInterface myNewIntface = (myInterface)myObject;

            //print the cool Method for the obj
            if (myObject.GetType() == typeof(my1stClass))
            {
                //use class 1 method
                myNewIntface.Cool();
            }
            else if (myObject.GetType() == typeof(my2ndClass))
            {
                //use class 2 method
                myNewIntface.Cool();
            }
            else 
            {
                Console.WriteLine("Not myClass1 or myClass2 objecct");
            }



        }


    }


}