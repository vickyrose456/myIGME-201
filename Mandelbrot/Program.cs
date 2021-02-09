using System;

namespace Mandelbrot
{

    // Class Program
    // Author: Victoria Olivieri
    // Purpose: This class generates Mandelbrot sets in the console window!
    // Restrictions: None

    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            double startVal = 0;
            double endVal = 0;
            bool bValid = false;

            //Enter a value to start
            Console.Write("Enter starting value: ");
            startVal = double.Parse(Console.ReadLine());

            //enter a value to end
            Console.Write("Enter ending value (less than starting value and less than 0): ");
            endVal = double.Parse(Console.ReadLine());

            //check to make sure start is greater than end
            //if it is not, get new user input until the input it correct
            //do not allow tha starting value to be less than endVal
           while (startVal <= endVal || endVal >= 0)
            {
                //catch to see if a string was entered.
                do
                {
                    try
                    {
                        //read num from keyboard as start val
                        //store the string as a double
                        Console.WriteLine("Enter the starting value");
                        startVal = Double.Parse(Console.ReadLine());
                        bValid = true;
                    }
                    catch
                    {
                        //let the user know it was invalid
                        Console.WriteLine("Not a valid number.");
                    }
                } while (!bValid);


                do
                {
                    try
                    {
                        //read num from keyboard
                        //store the string as a double
                        Console.WriteLine("Enter the ending value (greater than starting value and less than 0)");
                        endVal = double.Parse(Console.ReadLine());
                        bValid = true;
                    }
                    catch
                    {
                        //let the user know it was invalid
                        Console.WriteLine("Not a valid number.");
                    }
                } while (!bValid);
            }




            for (imagCoord = startVal; imagCoord >= -startVal; imagCoord -= startVal/24)
            {
                for (realCoord = endVal; realCoord <= -endVal*2.95; realCoord += -endVal/20)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
