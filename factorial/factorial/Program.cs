using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNumber = null;
            int nNumber = 0;
            int nAnswer = 0;


            do
            {
                Console.Write("Enter positiv number: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nNumber) && nNumber <= 0);

            //nswer = 1;
            /*
            while (nNumber > 0)
            {
                nAnswer *= nNumber;
                --nNumber;
            }
            */


            //N * (N-1) * (N -2) * (N -3)....
            //fact of n = cyclic loop
            //every recursive method has a base case



            nAnswer = Factorial(nNumber);

        }//end main

        static int Factorial(int v)
        {
            int returnVal = 0;
            int nextVal = 0;

            if (v == 0)
            {
                returnVal = 1;
            }
            else if (v < 0)
            {
                returnVal = -1;
            }
            else 
            {
                //fact of nnxt sequence
                nextVal = Factorial(v - 1);

                returnVal = v * nextVal;
            }

            return returnVal;

        }

    }
}
