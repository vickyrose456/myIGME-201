using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTestQ13
{
    //Class unit Test Q13
    //Author: Victoria Olivieri
    //Purpose: reWrite an Q12 which is an application that displays a salary raise if the users name is the
    //same as my own. If not, ouput their name with their salary
    //Restrictions: None.
    public class Program
    {

        struct employee
        {
            public string sName;
            public double dSalary;
        }
        

        //method: main
        //purpose: Prompt the user for their name and if it matches mine, then
        // they will see they got a raise. If not, the name and salary will output
        // without getting a raise
        //restrictions: none

        static void Main(string[] args)
        {
            //create employee var
            employee myEmployee;

            //tell user to enter name
            Console.WriteLine("Enter your name");

            //use sName to store the name from the console
            myEmployee.sName = Console.ReadLine();

            //set dSalary = 3000;
            myEmployee.dSalary = 3000.00;


            
            if (GiveRaise(myEmployee))
            {
                //add 19,999.99 to salary
                //myEmployee.dSalary += 1999.99;
                Console.WriteLine("Congrats, you got a raise! Your new salary is ${0}", myEmployee.dSalary);
            }
            else
            {
                Console.WriteLine("{0}'s salary is: ${1}", myEmployee.sName, myEmployee.dSalary);
            }
            
            
        }//main

        //method: GiveRaise
        //purpose: The function should increase the salary by $19,999.99 if name = your name and return true
        //Otherwise it should return false.
        //restrictions: none
        static bool GiveRaise(employee myEmployee)
        {
            //if name is my name then add salary
            if (myEmployee.sName.ToLower()=="victoria")
            {
                myEmployee.dSalary = myEmployee.dSalary + 19999.99;
                return true;
            }
            return false;
        }

    }//program
}//namespace
