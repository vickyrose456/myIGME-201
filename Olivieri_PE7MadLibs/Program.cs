using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olivieri_PE7MadLibs
{
    //Class PE7 - Mad Libs
    //Author: Victoria Olivieri
    //Purpose: Practice working with strings, lists, and input/output to create a madlibs game. 
    //using predetermined narratives stored in a txt file, gather info from user to generate a story. 
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: To allow the user to input data to play a mad lib game
        // Restrictions: None
        static void Main(string[] args)
        {
            //declare txt reader
            StreamReader txtInput;

            int numLines = 0;
            int cLibs = 0;  //counter for mad libs
            int userNum = 0; //user input of the story
            string userName = null;
            string userIn = null;
            string resultString = null;
            string yOrN = null;
            bool play = false;
            int inValidYorN = 0;
            bool bValid = false;

            //get the user's name
            Console.Write("What is your name?: ");
            userName = Console.ReadLine();

            //while the user does not input yes or no, keep asking for input
            do
            {
                //ask the user if they want to play
                Console.Write("Would you like to play a Mad Lab? (yes/no): ");
                yOrN = Console.ReadLine();

                if (yOrN.ToLower() == "yes")
                {
                    //user wants to play
                    Console.WriteLine("Awesome Let's Play!");
                    play = true;
                } else if (yOrN.ToLower() == "no")
                {
                    //user does not want to play so output goodbye
                    Console.WriteLine("Bye");
                    //exit the program
                    System.Environment.Exit(0);
                }
                
                else 
                {
                    if (inValidYorN == 2)
                    {
                        Console.WriteLine("Its been 3 tries.... type yes or no");
                    }
                    if (inValidYorN == 5)
                    {
                        Console.WriteLine("Are you even reading this? Enter yes or no");
                    }
                    if (inValidYorN >= 10)
                    {
                        Console.WriteLine("Alright {0}, how many times do we have to do this?", userName);
                    }

                    inValidYorN++;
                }
            } while (!play);
           



            //open the txt file and count the lines
            txtInput = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = txtInput.ReadLine()) != null)
            {
                //count the lines that are in the txt
                ++numLines;
            }

            //close the txt file
            txtInput.Close();

            //put the mad libs into array of strings
            string[] madLibs = new string[numLines];

            //read mad libs into the array of strings
            txtInput = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = txtInput.ReadLine())!= null)
            {
                //set array elem to current line of file
                madLibs[cLibs] = line;

                //replace"/n" w/ tage with new line
                madLibs[cLibs] = madLibs[cLibs].Replace("\\n", "\n");


                //increment the lib we are on
                ++cLibs;
            }

            //close out the txt file
            txtInput.Close();

            //promt user for mad lib selection
            while (!bValid)
            {
                Console.WriteLine("Which story would you like to choose? (1 though {0}: )", cLibs);
                try
                {
                     userNum = int.Parse(Console.ReadLine());
                    bValid = true;
                }   
                 catch
                {
                    Console.WriteLine("Invalid integer.");
                    bValid = false;
                }
            }
            

            //split the mad lib into words
            string[] words = madLibs[userNum].Split(' ');


            foreach (string word in words)
            {
                if (word == "\n")
                {
                    resultString += '\n';
                }
                //if word is a placeholder
                if (word.Contains('{'))
                {
                    //get rid of _ and brackets
                    string entry = word.Replace("_", " ");
                    entry = entry.Replace("{", " ");
                    entry = entry.Replace("}", " ");

                    //prompt user to insert data
                    Console.WriteLine("Enter a(n) {0}: ", entry);
                    userIn = Console.ReadLine();



                    //append user info and spaace for mad lib
                    resultString += userIn+ " ";
                }
                else 
                {
                    //else append word to result stirng 
                    resultString += word+ " ";
                }

            }//end for each

            Console.WriteLine(resultString);

        
        }//end main
    }//end program
}
