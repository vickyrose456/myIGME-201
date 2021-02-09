using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        
namespace Olivieri_PE4
{
    // Class Program
    // Author: Victoria Olivieri
    // Purpose: PE4 - Flow control
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Get 2 numbers from the user and check if both of them
        //are larger than 10, get 2 new numbers from the user.
        // Restrictions: None
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            bool validNum = false;

           

            do
            {
                //get number 1
                Console.WriteLine("Enter a number: " );
                num1 = Convert.ToInt32(Console.ReadLine());

                //get number 2
                Console.WriteLine("Enter another number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                //if both numbers are greater than 0, re enter the values
                if (num1 > 10 & num2 > 10)
                {
                    //alert the user to give a number less than 10
                    Console.WriteLine("Enter a number less than 10");
                }
                else 
                {
                    //output the numbers if at least one of them is less than 10
                    Console.WriteLine("Number 1: {0} \nNumber 2: {1}", num1, num2);
                    validNum = true;
                }
                

            } while (!validNum);

            






        }
    }
}
