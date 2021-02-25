using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTestQ4
{
    //class: Unit test question 4
    //Author: Victoria Olivieri
    //Purpose: 
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: Allow the user to choose b/w 3 questions. The user has
        // 5 seconds to answer the question correctly. If they answer incorrectly
        // then the correct answer is written 
        // Restrictions: None
        static void Main(string[] args)
        {
            bool bValid = false;

            //var for user question num
            int qNum = 0;
            //var for user input 
            string userIn = null;


        //the start of the game asks the user what question they want
        start:

            while (!bValid)
            {
                //ask user for input
                Console.WriteLine("Which question would you like? (1-3) ");
               
                try
                {
                    //read the input into qNum for the num question
                    qNum = int.Parse(Console.ReadLine());
                    //if the number is not 1, 2 or 3 then ask  for new user input
                    while (qNum < 1 ^ qNum > 3)
                    {
                        //get new input until it is 1 2 or 3
                        Console.WriteLine("Which question would you like? (1-3) ");
                        qNum = int.Parse(Console.ReadLine());
                    }
                    bValid = true;
                }catch
                {
                    //do nothing
                    bValid = false;
                }
            }
            








        }
    }
}
