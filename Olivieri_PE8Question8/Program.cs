using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE8Question8
{
    //Class PE8 - Question 
    //Author: Victoria Olivieri
    //Purpose: write an application that accepts a string and does case senstive replacement
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: The user will input a sentence. Case sensitive - replace the word
        //no with the word yes
        // Restrictions: None
        static void Main(string[] args)
        {
            string userIn = null;

            //get the input from the user
            Console.WriteLine("Enter a phrase using the word \"yes\" or \"no\"");
            userIn = Convert.ToString(Console.ReadLine());

            string[] sentence = userIn.Split(' ');
            

            for (int i = 0; i<sentence.Length; i++)
            {
                //if the word is no, write yes
                if (sentence[i] == "no")
                {
                    //replace the index with "yes"
                    sentence[i] = "yes";
                }
                
                Console.Write(sentence[i] + " " );
            }Console.WriteLine(".");


        }
    }
}
