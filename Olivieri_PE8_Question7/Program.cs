using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE8_Question7
{
    //Class PE8 - Question 7
    //Author: Victoria Olivieri
    //Purpose: Take user input as a string and output it in reverse order
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: Accept a string from the user and outputs a string w/ chars in reverse order
        // Restrictions: None
        static void Main(string[] args)
        {
            string userIn = null;
            string revInput = null;
            

            //get user input
            Console.WriteLine("Enter a word or phrase");
            //store input into variable
            userIn = Convert.ToString(Console.ReadLine());

            //store in temp array
            char[] letters = userIn.ToCharArray();


            for (int i = letters.Length; i >0 ; i--)
            {
                revInput = revInput + letters[i -1];
            }

            Console.WriteLine("The reverse order of your input: " + revInput);





            //Console.WriteLine(letters);
            
        }
    }
}
