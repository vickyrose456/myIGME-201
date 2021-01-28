//opening the system envelope w/o using the namespace prefix
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavColNum
{
    //put static in front of every class
    //include static = enforce everything inside class to be static

    //Class: Program 
    //Author: Victoria Olivieri
    //Purpose: Console read/write and exception handling ex.
    //Restrictions: None
    static class Program
    {
        //Method: Main
        //Purpose: Prompt the user for their fave col and num
        //      output their fave color (in limited text cols)
        //their fave number of times
        //Restrictions: None
        static void Main(string[] args)
        {
            //declare variables
            string color = null; //primative data type
            int faveNum = 0;
            bool bValid = false;

            //prompt the user for fave color 
            Console.Write("Enter your fave color:\t");

            //read color from the keyboard 
            //can only read string input
            //if not using system up top, then you would have to write System.Console.ReadLine();
            color = Console.ReadLine();

            //prompt user for fave number
            Console.Write("Enter your fave number: \t");

            //put into a loop to catch error
            do
            {

                try
                {
                    //read num from keyboard
                    //store the string as an integer
                    faveNum = Convert.ToInt32(Console.ReadLine());

                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                }
            } while (!bValid);

            //change the text color to their fave color. 
            //to lower will convert the string to all lowercase
            switch (color.ToLower())
            {
                //if its red or purple, execute this code
                case "red":
                case "purple":
                    Console.ForegroundColor = ConsoleColor.Red;
                    //this will skip this and go to the green case
                    //goto case "green";
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }//end switch 

            //output their fave color their fave number of times. 
            for (int i = 0; i < faveNum; i++)
            {
                Console.WriteLine("Your fave color is: " + color);
                //or this way
                Console.WriteLine("Fave color: {0}. Your fave num: {1}", color, faveNum);
                //Console.WriteLine($"Your fave color is {color} + "!");
            }
            


        }
    }
}
