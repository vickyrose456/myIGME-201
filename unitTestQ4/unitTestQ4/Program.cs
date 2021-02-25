using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace unitTestQ4
{
    //class: Unit test question 4
    //Author: Victoria Olivieri
    //Purpose: 
    //Restrictions: None.
    class Program
    {
        //timeout boolean 
        static bool bTimeOut = false;

        //timeouttimer boolean
        static Timer timeOutTimer;



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
            //variables of each answr
            string correct1 = "black";
            string correct2 = "42";
            string correct3 = "What do you mean? African or European swallow?";


        //the start of the game asks the user what question they want
        start:

            while (!bValid)
            {
                //ask user for input
                Console.Write("Which question would you like? (1-3) ");
               
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
                    //go through loop until true
                    bValid = false;
                }
            }
            //once user inputs the question number, ask the question 
            bValid = false;
            switch (qNum)
            {
                
                case 1:
                    //while input is valid, ask Q1
                    while (!bValid)
                    {
                        try
                        {
                            Console.WriteLine("What is your favorite color?");
                            userIn = Convert.ToString(Console.ReadLine());
                            bValid = true;
                        }
                    catch 
                        {
                            //if invalid, ask again
                            bValid = false;
                        }
                    } 

                    //check if the anwr is correct
                    //if the ans




                    break;
                case 2:
                     //while input is valid, ask Q2
                    while (!bValid)
                    {
                        try
                        {
                            Console.WriteLine("What is the answer to life, the universe and everything?");
                            userIn = Convert.ToString(Console.ReadLine());
                            bValid = true;
                        }
                        catch
                        {
                            //if invalid, ask again
                            bValid = false;
                        }
                    }
                    break;
                case 3:
                        //while input is valid, ask Q3
                     while (!bValid)
                    {
                        try
                        {
                            Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                            userIn = Convert.ToString(Console.ReadLine());
                            bValid = true;
                        }
                        catch
                        {
                            //if invalid, ask again
                            bValid = false;
                        }
                    }
                    break;
            }
            








        }
    }
}
