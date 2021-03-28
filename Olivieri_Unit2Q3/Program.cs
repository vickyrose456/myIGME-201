using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olivieri_Unit2Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dx = 0.0;
            double dy = 0.0;
            double dw = 0.0;
            double dz = 0.0;
            int nx = 0;
            int ny = 0;
            int nw = 0;

            Tuple<double, double, double> formula = new Tuple<double, double, double>(11, 21, 41);

            for (dw = -2; dw <= 0; dw += 0.2)
            {
                dw = Math.Round(dw, 1);
                dy = 0;
                dx = 0;
                for (dy = -1; dy <= 1; dy += 0.1)
                {
                    dy = Math.Round(dy, 1);
                    dw = 0;
                    dx = 0;

                    for (dx = 0; dx <= 4; dx += 0.1)
                    {
                        dx = Math.Round(dx, 1);
                        dz = (4 * Math.Pow(dy, 3)) + (2 * Math.Pow(dx, 2)) - (8 * dw) + 7;
                        dz = Math.Round(dz, 3);

                        //store into tuple
                        new Tuple<double, double, double, double>(dw, dy, dx, 0);
                        new Tuple<double, double, double, double>(dw, dy, dx, 1);
                        new Tuple<double, double, double, double>(dw, dy, dx, 2);
                        new Tuple<double, double, double, double>(dw, dy, dx, 3);
                        ++nx;

                    }

                    ++ny;
                }
                ++nw;
            }

        }
    }
 }
