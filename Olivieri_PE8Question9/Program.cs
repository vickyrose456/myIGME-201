using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE8Question9
{
    //Class PE8 - Question 9
    //Author: Victoria Olivieri
    //Purpose: Write an application that places double quotes around each word in a string
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: Puts " " around each word in a string
        // Restrictions: None
        static void Main(string[] args)
        {
            string userIn = null;

            //iput from user
            Console.WriteLine("Enter a word/phrase. ");
            userIn = Convert.ToString(Console.ReadLine());

            string[] words = userIn.Split(' ');

            for (int i = 0; i< words.Length; i++)
            {
                Console.Write("\"{0}\" ", words[i]);
            }



        }
       

    }
}
