using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE6
{
    // Class Program
    // Author: Victoria Olivieri
    // Purpose: PE6 - Parsing and Formatting 
    // Restrictions: None
    static class Program
    {
        // Method: Main
        // Purpose: Create a simple number guessing game. It will generate
        //a random int b/w 0 and 100 and a player will try to guess it.
        // Restrictions: None
        static void Main(string[] args)
        {
            int userNum = 0;

            //initialize rand to be call the Random class
            Random rand = new Random();

            //generate the random int b/w 0 and 100
            int randomNum = rand.Next(0, 101);

            //test the program
            Console.WriteLine("My num: {0}", randomNum);

            //promt the user to guess a number
            Console.Write("Guess the random number between 0 and 100");
            userNum = int.Parse(Console.ReadLine());
        }
    }
}
