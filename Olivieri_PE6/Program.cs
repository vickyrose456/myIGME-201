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
            int numOfTries = 0;
            int winTries = 0;

            //initialize rand to be call the Random class
            Random rand = new Random();

            //generate the random int b/w 0 and 100
            int randomNum = rand.Next(0, 101);

            //test the program
            Console.WriteLine("My num: {0}", randomNum);


            while (numOfTries < 8)
            {
                
                //promt the user to guess a number
                Console.WriteLine("Turn: {0}. Guess the random number between 0 and 100: ", (numOfTries+1));
                //enter the data into userNum
                userNum = int.Parse(Console.ReadLine());

                //check if the user number is less than 0 or greater than 100
                while ((userNum < 0) ^ (userNum > 100))
                {
                    //if its invalid prompt the user to enter a valid one
                    Console.WriteLine("Invalid. \n Turn: {0}." +
                        "Enter an integer between 0 and 100: ", (numOfTries+1));
                    userNum = int.Parse(Console.ReadLine());
                }

                //output the user's number
                //Console.WriteLine("Your num: {0}", userNum);

                //check if the user input matches the random number
                if (userNum == randomNum)
                {
                    //congrats outputed to user
                    //Console.WriteLine("CONGRATS! You guessed {0} correct on try #{1}!", userNum, (numOfTries+1));

                    //increment the number of times through the loop
                    //winTries++;

                    //set num of tries = 8 to stop the while loop
                    numOfTries = 8;

                } else if (userNum < randomNum)
                {
                    Console.WriteLine("Your number, {0}, Is Too Low!!!", userNum);
                }
                else if (userNum > randomNum)
                {
                    Console.WriteLine("Your number, {0}, Is Too High!!!", userNum);
                }

                //increment the number of tries for the while loop
                numOfTries++;
                winTries++;
            }

            //check if the user data is equal to the random number
            if (userNum == randomNum)
            {
                //congrats outputed to user
                Console.WriteLine("CONGRATS! You guessed {0} correct on try #{1}!", userNum, (winTries));

            }
             //If over 8 tries, then they lost. so print that to user
            if (winTries <= 8)
            {

                
            }
            else 
            { 
                //print the correct number to user
                Console.WriteLine("Sorry, you ran out of tries :( \nThe number was {0}", randomNum);
            }
            
            
           
        }
    }
}
