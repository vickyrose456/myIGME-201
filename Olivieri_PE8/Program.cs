using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE8
{
    //Class PE8 - Question 5
    //Author: Victoria Olivieri
    //Purpose: use formula z = 3y^2 + 2x - 1 based on values of x and y using an array
    //Restrictions: None.
    class Program
    {
        // Method: Main
        // Purpose: Use formula to get values of z into a 3-dim array (x, y, z)
        //The ranges include:
            //•	-1 <= x <= 1 in 0.1 increments
            //•	1 <= y <= 4 in 0.1 increments
        // Restrictions: None
        static void Main(string[] args)
        {
            //question 5 application
            //declare 3dim double array to store x y and z
            double[,,] computation;
            double z = 0.0;

            //while y is between 1 and 4, do calc
            for (double y = 1; y <= 4.0; y += .01)
            {
                //while x is between -1 and 1, do calc
                for(double x= -1.0; x<= 1; x+= .01)
                {
                    //do calc w/ x and y to find z
                    z = (3 * Math.Pow(y, 2)) + (2 * x) - 1;
                    Console.WriteLine(z);
                }
            }

            //Console.WriteLine(z);

        }//end main

    }//class program

}//namespace end

