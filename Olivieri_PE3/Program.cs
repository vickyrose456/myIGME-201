using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_PE3
{
    // Class Program
    // Author: Victoria Olivieri
    // Purpose: PE3 - Variables and Expressions
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Get 4 numbers from the user and output the product of them. 
        // Restrictions: None
        static void Main(string[] args)
        {
            //declare all integers and the final product 
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int numProduct = 0;
            bool bValid = false;

            
                //Ask user to input for the number
                Console.WriteLine("Enter 1st integer.");
            //catch the string error
            do
            {
                try
                {
                    //read num from keyboard
                    //store the string as an integer
                    num1 = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    //let the user know it was invalid
                    Console.WriteLine("Not a valid integer.");
                }
            } while (!bValid);

            //Ask user to input for the number
            Console.WriteLine("Enter 2nd integer.");
            //catch the string error
            bValid = false;
            do
            {
                try
                {
                    //read num from keyboard
                    //store the string as an integer
                    num2 = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    //let the user know it was invalid
                    Console.WriteLine("Not a valid integer.");
                }
            } while (!bValid);

            

            //Ask user to input for the number
            Console.WriteLine("Enter 3rd integer.");
            //catch the string error
            bValid = false;
            do
            {
                try
                {
                    //read num from keyboard
                    //store the string as an integer
                    num3 = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    //let the user know it was invalid
                    Console.WriteLine("Not a valid integer.");
                }
            } while (!bValid);


            //Ask user to input for the number
            Console.WriteLine("Enter 4th integer.");
            //catch the string error
            bValid = false;
            do
            {
                try
                {
                    //read num from keyboard
                    //store the string as an integer
                    num4 = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch
                {
                    //let the user know it was invalid
                    Console.WriteLine("Not a valid integer.");
                }
            } while (!bValid);

            //get the product of all the numbers 
            numProduct = num1 * num2 * num3 * num4;
            //output the product 
            Console.WriteLine("The product of those numbers is: {0}", numProduct);


            /*
            Console.Write("Enter a number: ");

            //catch the string error
            do
            {
                try
            {
                //read num from keyboard
                //store the string as an integer
                num1 = Convert.ToInt32(Console.ReadLine());

                bValid = true;
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
            }

            } while (!bValid);
            try
            {
                //read num from keyboard
                //store the string as an integer
                nums = Convert.ToInt32(Console.ReadLine());

                bValid = true;
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
            }



            //Convert the string input to an integer
            num1 = Convert.ToInt32(Console.ReadLine());

            //Get input number 2
            Console.Write("Enter a number: ");
            //convert input 2
            num2 = Convert.ToInt32(Console.ReadLine());

            //get input 3
            Console.Write("Enter a number: ");
            //convert the input 3
            num3 = Convert.ToInt32(Console.ReadLine());

            //ask user for input 4
            Console.Write("Enter a number: ");
            //convert input 4
            num4 = Convert.ToInt32(Console.ReadLine());

            //get the product of all the numbers 
            numProduct = num1 * num2 * num3 * num4;
            //output the product 
            Console.WriteLine("The product of those numbers is: {0}", numProduct);

            */

        }
    }
}
