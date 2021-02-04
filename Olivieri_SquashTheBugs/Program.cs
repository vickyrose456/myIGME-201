using System;

namespace Olivieri_SquashTheBugs
{
    // Class Program
    // Author: Victoria Olivieri
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 //Compile time error --> missing ;
            int i = 0;
            //declared string to hold all numbers
            string allNumbers = null;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) //logic error --> wont reach the number 10 here
            for (i =1; i<= 10; ++i) 
            {
                // declare string to hold all numbers
                //string allNumbers = null; //logic error --> we need to declare outside of the loop so that this variable is defined throughout the main


                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); //Compile error
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1)); Run time error --> 1/0 is undefined
               
                if (i == 1)
                {
                    Console.Write("undefined\n");
                }
                else
                {
                    Console.Write((double)i / (i - 1) + "\n"); //outputed a double to get an accurate number (instead of integer)
                }



                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; //Logic error --> do not need to increment within a loop
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);//Compile error --> incorrect concatination
            Console.WriteLine("\nThese numbers have been processed: " + allNumbers);
        }
    }
}
