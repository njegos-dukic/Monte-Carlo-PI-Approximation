using System;

namespace MonteCarlo
{
    class MonteCarloModes
    {
        public static void MonteCarloPIApproximationIterations(long iterations)
        {
            int total = 0;
            int insideCircle = 0;

            double x, y;
            Random rnd = new Random();

            while (total < iterations)
            {
                x = rnd.NextDouble();
                y = rnd.NextDouble();

                if ((Math.Sqrt(x * x + y * y) <= 1.0))
                    insideCircle++;

                total++;
            }

            double pi = 4 * ((double)insideCircle / (double)total);

            System.Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine($"\nPI = {Simulation.PIValue}");
            System.Console.ForegroundColor = ConsoleColor.White;

            System.Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Iterations = {iterations} => PI = {pi}");
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        public static void MonteCarloPIApproximationPrecision(byte precision)
        {
            double pi = 0;
            int total = 0;
            int insideCircle = 0;

            double x, y = 0;
            Random rnd = new Random();

            string stringPI = "0.0";
            string targetPI = Simulation.PIValue.Substring(0, precision + 2);

            while (stringPI != targetPI)
            {
                x = rnd.NextDouble();
                y = rnd.NextDouble();

                if ((Math.Sqrt(x * x + y * y) <= 1.0))
                    insideCircle++;

                total++;
                pi = 4 * ((double)insideCircle / (double)total);

                if (pi.ToString().Length >= precision + 2)
                    stringPI = pi.ToString().Substring(0, precision + 2);
            }

            System.Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine($"\nPI = {Simulation.PIValue}");
            System.Console.ForegroundColor = ConsoleColor.White;

            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Iterations = {total} => PI = {stringPI}");
            System.Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
