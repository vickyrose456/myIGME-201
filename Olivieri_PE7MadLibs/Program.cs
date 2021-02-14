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
        // Purpose: 
        // Restrictions: None
        static void Main(string[] args)
        {
            //declare txtInput
            StreamReader txtInput = null;

            try
            {
                //use txtInput to store the data from the text file
                txtInput = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
                String line = txtInput.ReadLine();
            }
            catch (Exception e)
            {
                //if there was an error print a message
                Console.WriteLine("Error with file: " + e.Message);
            }
            finally 
            {
                //if theres no more text, stop reading the file
                if (txtInput != null)
                {
                    txtInput.Close();
                }
            }





        }
    }
}
