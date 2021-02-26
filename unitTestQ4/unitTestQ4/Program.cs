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

        //correct answer 
        static string sCorrect = "";



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
            //string sCorrect = "";

            //string to hold the question
            string sQuestion = "";
            
            //play again string
            string sAgain = "";



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
              
            //once user inputs the question number, ask the question based on input 
            bValid = false;
            switch (qNum)
            {
                case 1:
                    //Console.WriteLine("What is your favorite color?");
                    sQuestion = "What is your favorite color?";
                    //set the answer to the correct one
                    sCorrect = "black";
                    break;
                case 2:
                     //Console.WriteLine("What is the answer to life, the universe and everything?");
                    sQuestion = "What is the answer to life, the universe and everything?";
                    //set the answer to the correct one
                    sCorrect = "42";
                    break;
                case 3:
                    //Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    sQuestion = "What is the airspeed velocity of an unladen swallow?";
                    //set the answer to the correct one
                    sCorrect = "What do you mean? African or European swallow ?";
                    break;
            }

            //create timeouttimer w/ time of 5 sec
            timeOutTimer = new Timer(5000);

            //use timer delegate
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

            //initialize timeout 
            bTimeOut = false;

            //start the timer
            timeOutTimer.Start();

            
            do
            {
                //display question
                Console.WriteLine("You have 5 seconds to answer the following question:");
                Console.WriteLine(sQuestion);
                //get response
                userIn = Convert.ToString(Console.ReadLine());
          

                //stop the timer when enter is pressed
                timeOutTimer.Stop();

                //if timer timed out. Response was wrong. display correct one and get 
                //out of this loop
                if (bTimeOut) 
                {   
                    //time is up outputted
                    //Console.WriteLine("Time is up!");
                    //display correct answer
                    //Console.WriteLine("The answer is: {0}", sCorrect);
                    break;
                }

                //make sure input is valid
                try
                {
                    userIn = Convert.ToString(userIn);
                    bValid = true;
                }
                catch { bValid = false; }


            } while (!bValid);


            //if the input is right
            if (userIn.Equals(sCorrect))
            {
                //ouput well done
                Console.WriteLine("Well done!");
            }//if the user input is incorrect
            else if (userIn == " " ^ userIn == "")
            {
                //do nothing b/c ran out of time
            }
            else 
            {
                //ouput correct answer
                Console.Write("Wrong!");
                Console.WriteLine("The answer is: {0}", sCorrect);
            }
            
            
            bValid = false;
            //while true
            do
            {
                //output Do you want to play again
                Console.Write("Play again? ");

                sAgain = Convert.ToString(Console.ReadLine());

                 //if yes, goto start
                if (sAgain.ToLower().StartsWith("y"))
                {
                    goto start;
                }
                //if no, end the program
                else if (sAgain.ToLower().StartsWith("n"))
                {
                    break;
                }
            } while (true);


        }//main

        // Method: Main
        // Purpose: Timesup will be called when the timer elapses. the user will be told the 
        // time is up
        // Restrictions: None
        static void TimesUp(object source, ElapsedEventArgs e)
            {
                //Times up outputted when timer is done
                Console.WriteLine("Time is up!");

                //output correct answer
                Console.WriteLine("The answer is: {0}", sCorrect);

                //stop the timer
                timeOutTimer.Stop();

                //tell user to press enter
                Console.WriteLine("Please press enter.");
            
                //set time out
                bTimeOut = true;

        }//TimesUp

    }//program


}//namespace