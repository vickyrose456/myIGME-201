using System;

namespace unitTestQ2
{
    //Class Unit test - Question 2
    //Author: Victoria Olivieri
    //Purpose:  Modify the number sorter application to request 
    //Restrictions: None.
    class Program
    {
        // the definition of the delegate function data type
        delegate string sortingFunction(string[] a);


        // Method: Main
        // Purpose: Sort the words in a sentence in either ascending
        // or descending order depending on the user input
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            string[] aUnsorted;
            string[] aSorted;

            // declare the delegate variable which will point to the function to be called
            sortingFunction findHiLow;

        //label to easily loop back to start if there are input issues
        start:
            Console.WriteLine("Enter a list of space-seperated words");

            //read the string of words
            string sWords = Console.ReadLine();

            //split the string of words
            string[] sWord = sWords.Split(' ');

            //initialize the size of unsorted array to 0
            int nUnsortedLength = 0;

            //a string to hold current element in array
            string nThisWord = null;

            //iterate through the array of words
            foreach (string sThisWord in sWord)
            {
                //if length is 0 the string is null (typed 2 spaces)
                if (sThisWord.Length == 0)
                {
                    //skip it
                    continue;
                }

                nThisWord = sThisWord;
                ++nUnsortedLength;

            }

            //allocate the size of the unsorted array
            aUnsorted = new string[nUnsortedLength];

            //reset unsorted length back to 0 as index to store words in array
            nUnsortedLength = 0;
            foreach (string sThisWord in sWord)
            {
                //skip blank strings
                if (sThisWord.Length == 0)
                {
                    continue;
                }
                //assign current word val to n this word
                nThisWord = sThisWord;

                //store the value into the array
                aUnsorted[nUnsortedLength] = nThisWord;

                //increment array
                nUnsortedLength++;
            }

            //allocate size to sorted array
            aSorted = new string[nUnsortedLength];

            // prompt for <a>scending or <d>escending
            Console.Write("Ascending or Descending? ");
            string sDirection = Console.ReadLine();

            if (sDirection.ToLower().StartsWith("a"))
            {
                findHiLow = new sortingFunction(FindLowestVal);
            }
            else 
            {
                findHiLow = new sortingFunction(FindHighestVal);
            }

            //start sorted length at 0
            int nSortedLength = 0;

            //while there are unsorted vals to sort
            while (aUnsorted.Length > 0)
            {
                //store lowest or highest val as next val
                aSorted[nSortedLength] = findHiLow(aUnsorted);

                //remove current sorted value
                RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                //increment num of vals in sorted array
                ++nSortedLength;
            }

            //write the sorted arrray of words
            Console.WriteLine("The sorted list is: ");
            foreach (string thisWord in aSorted)
            {
                Console.Write($"{thisWord} " );
            }
            Console.WriteLine();

        }//end main  


        //find lowest val in array
        static string FindLowestVal(string[] array)
        {

            return "";
        }








    }//end program

}//end namespace