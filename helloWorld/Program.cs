using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Victoria Rose Olivieri");

            //Testing Diff Variables

            var i = 2;
            var iplus3 = i + 3;
            Console.WriteLine("i plus 3: " + iplus3);

            string hbd;
            hbd = "Happy Birthday";
            Console.WriteLine(hbd + " Samantha!");


            //if statement using an integer and a double
            double juice = 2.5;
            int melon;

            if (juice >= 2.5)
            {
                melon = 20;
            }
            else
            {
                melon = 1;
            }

            Console.WriteLine("juice: " + juice);
            Console.WriteLine("melon: " + melon);

            //finding the area of a triangle with 3 variables
            double triBase = 12.0;
            double triHeight = 53.8;

            //need to make sure the fraction gives a double by adding .0
            //otherwise the math is incorrect in this case
            double areaTri = (1.0 / 2.0) * triBase * triHeight;
            Console.WriteLine("area of triangle: " + areaTri);


            //for loop that will print 5 times "WEEE.."

            Console.WriteLine("Im in a for loop!");
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("WEEEEEEEEE");
                if (c == 4)
                { Console.WriteLine("Woah im dizzy"); }
            }//end for loop


            //while loop test
            int puppies = 0;

            //while i have less than 3 puppies, i am happy
            while (puppies <= 2)
            {
                Console.WriteLine("I need another puppy!");
                puppies++;
            }
            Console.WriteLine("No more puppies");

        }//end main
    }//end class program
}//end namespace