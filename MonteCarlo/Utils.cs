using System;

namespace MonteCarlo
{
    class Utils
    {
        public static void Interpret()
        {
            System.Console.WriteLine("Please select: ");
            System.Console.WriteLine("  1 - Iterations");
            System.Console.WriteLine("  2 - Precision");

            System.Console.Write("\nEnter: ");

            int mode;

            try
            {
                mode = int.Parse(System.Console.ReadLine());
                if (mode != 1 && mode != 2)
                    throw new ArgumentException("Invalid.");
            }
            catch
            {
                System.Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("Please specify 1 or 2.\n");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            switch (mode)
            {
                case 1:
                    {
                        while (true)
                        {
                            System.Console.Write("\nPlease specify number of iterations: ");
                            long iterations;

                            try
                            {
                                iterations = long.Parse(System.Console.ReadLine());
                                MonteCarloModes.MonteCarloPIApproximationIterations(iterations);
                                System.Console.WriteLine();
                                return;
                            }

                            catch
                            {
                                System.Console.ForegroundColor = ConsoleColor.DarkRed;
                                System.Console.WriteLine("Please specify integer value.");
                                System.Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }

                case 2:
                    {
                        while (true)
                        {
                            System.Console.Write("\nPlease specify desired precision: ");
                            byte precision;

                            try
                            {
                                precision = byte.Parse(System.Console.ReadLine());
                                if (precision > 16)
                                    throw new ArgumentException("Too big.");

                                MonteCarloModes.MonteCarloPIApproximationPrecision(precision);
                                System.Console.WriteLine();
                                return;
                            }

                            catch
                            {
                                System.Console.ForegroundColor = ConsoleColor.DarkRed;
                                System.Console.WriteLine("Please specify integer value smaller than 16.");
                                System.Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
            }
        }
    }
}
