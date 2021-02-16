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
            double x = 0.0;
            double y = 0.0;
            double z = 0.0;

            int nX = 0;
            int nY = 0;
            int nMaxY = 0;


            //count the amount of data points for x and y
            for (x = -1, nX = 0; x <= 1; x += 0.1, ++nX)
            {
                x = Math.Round(x, 1);
            }
            for (y= 1, nY = 0; y <= 4; y += 0.1, ++nY)
            {
                y = Math.Round(y, 1);
            }

            nMaxY = nY;


            //declare array w/ corect size
            double[][][] zArray = new double[nMaxY][][];

            //while x is b/w -1 and 1 do the calc 
            for (x = -1, nX = 0; x <= 1; x += 0.1, ++nX)
            {
                x = Math.Round(x, 1);

                //declare array within the array to store x val in correct index
                zArray[nX] = new double[nMaxY][];
                for (y = 1, nY = 0; y <= 4; y += 0.1, ++nY)
                {
                    y = Math.Round(y, 1);

                    //declare to store into the correct dimension of array
                    zArray[nX][nY] = new double[3];

                    //do actual calculation to findd z
                    z = (3 * Math.Pow(y, 2)) + (2 * x) - 1;

                    //store the correct values into the correct index



                }
               

            }





/*
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
*/

            //Console.WriteLine(z);

        }//end main

    }//class program

}//namespace end

