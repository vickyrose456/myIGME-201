﻿using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY --> forgot ; -compile error
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); //Needs "" - Compile error
            Console.WriteLine("This program calculates x^y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine();
            } //while (!int.TryParse(sNumber, out nX)); //compile error - sNumber has no value assigned to it
            while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                //sNumber = Console.ReadLine(); logic error - sNumber is already defined
                //need to assign this input to nY(need to convert from string to int)
                nY = Convert.ToInt32(Console.ReadLine());
            } //while (int.TryParse(sNumber, out nX));
            while (!int.TryParse(sNumber, out nX));//runtime error - need to put !, otherwise it will continue 
            //to ask for a y value


            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY);//compile error - nY has no vallue assigned to it
            
            
            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); //Logic error - need to put $ in order for values to print
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }//main


         //int Power(int nBase, int nExponent)
        static int Power(int nBase, int nExponent) //logic error - need to be 5static in so that main can access it
        {
            int returnVal = 0;
            int nextVal = 0;

            
            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                return 1;//logic error - if exponent is 0, the answer is 1
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); //logic error - want to be decrementing exponent, 
                //not adding it, otherwise this will keep going forever
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; //compile error - need to return an int
            return returnVal;
            

        }//power

    }//program

}//namespace