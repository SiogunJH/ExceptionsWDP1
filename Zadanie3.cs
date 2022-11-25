using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie3
    {
        public static void Main()
        {
            // QuadraticEquation(1, 3, 2);
            // QuadraticEquation(1, -2, 1);
            // QuadraticEquation(1, 1, 1);
            // QuadraticEquation(0, 0, 0);
            // QuadraticEquation(0, 0, 1);
            // QuadraticEquation(0, 2, 1);
            QuadraticEquation(1000000, 6000, -300295);
        }
        public static void QuadraticEquation(int a, int b, int c)
        {
            //INFINITY
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("infinity");
                return;
            }

            //EMPTY
            double delta;
            try
            {
                checked
                {
                    delta = (b * b) - (4 * a * c);
                }
            }
            catch (OverflowException)
            {
                long temp = b;
                temp *= b;
                long temp2 = 4;
                temp2 *= a;
                temp2 *= c;
                delta = Decimal.Parse(temp);
            }
            Console.WriteLine(delta);

            if (delta < 0 || (a == 0 && b == 0))
            {
                Console.WriteLine("empty");
                return;
            }

            //ONE X
            double results;
            string temp;
            if (a == 0)
            {
                results = -1 * (double)c / (double)b;
                results = Math.Round(results, 2);
                temp = String.Format("x={0:F2}", results);
                temp = temp.Replace(',', '.');
                Console.WriteLine(temp);
                return;
            }

            if (delta == 0)
            {
                results = (-1 * (double)b) / (2 * (double)a);
                results = Math.Round(results, 2);
                temp = String.Format("x={0:F2}", results);
                temp = temp.Replace(',', '.');
                Console.WriteLine(temp);
                return;
            }

            //TWO X
            if (delta > 0)
            {
                results = ((-1 * (double)b) - Math.Sqrt(delta)) / (2 * (double)a);
                results = Math.Round(results, 2);
                temp = String.Format("x1={0:F2}", results);
                temp = temp.Replace(',', '.');
                Console.WriteLine(temp);

                results = ((-1 * (double)b) + Math.Sqrt(delta)) / (2 * (double)a);
                results = Math.Round(results, 2);
                temp = String.Format("x2={0:F2}", results);
                temp = temp.Replace(',', '.');
                Console.WriteLine(temp);
                return;
            }
        }
    }
}