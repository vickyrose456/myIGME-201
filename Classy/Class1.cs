using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
        //public abstract class
        public abstract class myAClass
        {
            //private field
            private int myVar;

            //read, write prop that accesses private field
            public int GetMyVar
            {
                get 
                {
                    return this.myVar;
                }
                set 
                {
                    try
                    {
                        //get variable from user. if its invalid, then the number is 57
                        Console.WriteLine("enter an integer.");
                        this.myVar = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        this.myVar = 57;
                    Console.WriteLine("Invalid input. Therefore the integer is: {0}", this.myVar);
                    }
                        
                    
                }
            }

        public void PrintVar()
        {
            Console.WriteLine(GetMyVar);
        }


        }//my class
    //create 1st class that inherits interface
        public class my1stClass : myAClass, myInterface
        {
            //inhert method
            public void Cool()
            {
                Console.WriteLine("My 1st class is super cool!");
            }

        }//1st class

    //create 2nd class that inherits interface
        public class my2ndClass : myAClass, myInterface
        {
        //method that uses inherited interface void
            public void Cool()
            {
                Console.WriteLine("My 2nd class is cooler. ");
            }

        }//my 2nd class

    public interface myInterface 
    {
        void Cool();
       
    }
    
}
