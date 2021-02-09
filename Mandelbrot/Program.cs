using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


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

            //do not allow tha starting value o be 
           while (startVal <= endVal)
            {
                do
                {
                    try
                    {
                        //read num from keyboard as start val
                        //store the string as a double
                        Console.WriteLine("Enter the starting value");
                        startVal = Convert.ToInt32(Console.ReadLine());
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
                        Console.WriteLine("Enter the ending value");
                        endVal = Convert.ToDouble(Console.ReadLine());
                        bValid = true;
                    }
                    catch
                    {
                        //let the user know it was invalid
                        Console.WriteLine("Not a valid number.");
                    }
                } while (!bValid);
            }
            


            


            for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
            {
                for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
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
