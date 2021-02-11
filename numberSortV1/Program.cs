using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSortV1
{
    //Week 3 Class example
    class Program
    {
        static void Main(string[] args)
        {
            //declare the unsorted and sorted arrays.
            int[] aUnsorted;
            int[] aSorted;

        //a label to allow us to earily loop back to the start if there are input issues
        start:
            Console.WriteLine("Enter a list of space-seperated numbers");

            string sNumString = Console.ReadLine();

            //split into array
            string[] sNums = sNumString.Split(' ');

            //initialize size of unsorted array to 0
            int nUnsortedLength = 0;

            //a int used for parsing
            int nThisNum;

            //iterate through array of strings
            foreach (string sThisNumber in sNums)
            {
                //if length os tring is 0
                if (sNums.Length == 0)
                {
                    //skip it
                    continue;
                }

                try
                {
                    //try to parse current string
                    nThisNum = int.Parse(sThisNumber);

                    //if successful, increemnt unsorted val
                    ++nUnsortedLength;
                }
                catch
                {
                    //if an exception, indicate num is invalid
                    Console.WriteLine($"Number #(nUnsortedLength + 1) is not a valid number.");

                    //loop back to start
                    goto start;
                }

                //now we know how many unsorted
                //allocate size of unsorted arrat
                aUnsorted = new int[nUnsortedLength];

                //reset nUnsortedLengh back to 0 to use as index for unsorted array
                nUnsortedLength = 0;

                foreach (string sThisNum in sNums)
                {
                    //still skip the blank strings
                    if (sThisNum.Length == 0)
                    {
                        continue;
                    }

                    //parse each num in the list
                    nThisNum = int.Parse(sThisNum);

                    //store into the array
                    aUnsorted[nUnsortedLength] = nThisNum;

                    //increment array index
                    nUnsortedLength++;

                }//end foreach

                //alocate size of sorted arry
                aSorted = new int[nUnsortedLength];

                //start the sorted length at 0
                int nSortedLength = 0;

                while (aUnsorted.Length > 0)
                {
                    //store lowest unsorted as next sorted
                    aSorted[nSortedLength] = FindLowestValue(aUnsorted);

                    //remove the current sorted value
                    RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                    //increment the num of values in sorted array
                    ++nSortedLength;

                }

            }//end for each



        }//end main
    }//end class
}
