﻿using System;
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
        // Purpose: 
        // Restrictions: None
        static void Main(string[] args)
        {
            //declare txt reader
            StreamReader txtInput;

            int numLines = 0;
            int cLibs = 0;  //counter for mad libs
            int userNum = 0;
            string userName = null;

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



            //split the mad lib into words
            string[] words = madLibs[userNum].Split(' ');

            foreach (string word in words)
            {
                //if word is a placeholder

                //prompt user for replacement

                //add append the user response to resultString

                //else append word to result stirng 


            }



        
        }//end main
    }//end program
}
