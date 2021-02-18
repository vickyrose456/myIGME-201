using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE9Question3
{
    //Class PE9 - Question 3
    //Author: Victoria Olivieri
    //Purpose:  create a delegate fns and use it to impersonate console.readline()
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: get user input and invoke the delegate fns to print it
        // Restrictions: None
        static void Main(string[] args)
        {
            //ask for user  input
            
            Console.WriteLine("Enter a word/phrase.");
            inputString();
            //Console.WriteLine(inputString());



        }//end main

        static string inputString()
        {
            string stringInput = null;
            stringInput = Console.ReadLine();
            return stringInput;
        }
       

}//end program
    

}//end namespace
