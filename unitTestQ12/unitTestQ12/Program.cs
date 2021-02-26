using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTestQ12
{
    //Class unit Test Q12
    //Author: Victoria Olivieri
    //Purpose: Write an application that displays a salary raise if the users name is the
    //same as my own. If not, ouput their name with their salary
    //Restrictions: None.
    class Program
    {
        //method: main
        //purpose: Prompt the user for their name and if it matches mine, then
        // they will see they got a raise. If not, the name and salary will output
        // without getting a raise
        //restrictions: none
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;
            /*
                It should prompt for the user's name, then call the following function:

                The main program should congratulate the user if they got a raise, 
                and display their new salary.

                */

            //prompt for name
            Console.WriteLine("Enter your name: " );
            sName = Convert.ToString(Console.ReadLine());

            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congrats, you got a raise! Your new salary is ${0}", dSalary);
            }
            else
            {
                Console.WriteLine("{0}'s salary is: ${1}", sName, dSalary);
            }
            
            
        }//main

        //method: GiveRaise
        //purpose: The function should increase the salary by $19,999.99 if name = your name and return true
        //Otherwise it should return false.
        //restrictions: none
        static bool GiveRaise(string name, ref double salary)
        {
            //if name is my name then add salary
            if (name.ToLower() == "victoria")
            {
                //add 19,999.99 to salary
                salary += 19999.99;
                return true;
            }
            else 
            {
                return false;
            }
        }


    }//program
}//namespace
