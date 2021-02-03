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
            //int i = 0
            int i = 0;

            //declare string to hold numbers
            string allNumbers = null;

            // loop through the numbers 1 through 10
            for (i = 1; i <= 10; ++i)
            {

                // declare string to hold all numbers
                //string allNumbers = null; --> Need to declare outside of the for loop

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i-1) + " = ");

                // output the calculation based on the numbers
                if (i == 1)
                {
                    Console.Write("undefined ");
                } else
                { 
                    Console.Write((double)i / (i - 1) + " ");
                }
                

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; --> Dont need to increment in a for loop.
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }//end main
    }//end program
}
