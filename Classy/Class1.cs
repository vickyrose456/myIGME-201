using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    public class Class1
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
                    }
                        
                    
                }
            }
        }
    }
}
