using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTestQ3
{
    //class: Unit test question 3
    //Author: Victoria Olivieri
    //Purpose: Create a console application that uses
    //a delegate to impersonate the Console.ReadLine() function when asking for user input
    //Restrictions: None.
    class Program
    {
        //declare delegate function
        delegate string MyReadLine();


        // Method: Main
        // Purpose: Use delegates to impersonate readline function
        // Restrictions: None
        static void Main(string[] args)
        {
            //create a var to call fns
            MyReadLine myReadLine;

            //construct delegate fns ref to point to console.readline
            myReadLine = new MyReadLine(Console.ReadLine);

            //call the new fns
            string readString = myReadLine();

        }
    }
}
