using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie1
    {
        public static void Main1()
        {
            try
            {
                Console.WriteLine(TrianglePerimeter(1, 2, 10, 8));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Oblicza obwód trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
        /// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
        /// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>obwód trójkąta obliczony z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
        ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
        /// <remarks>dopuszczamy trójkąt o pokrywających się bokach lub o wszystkich bokach o długości 0</remarks>
        public static double TrianglePerimeter(int a, int b, int c, int precision = 2)
        {
            if (!(
                a >= 0 &&
                b >= 0 &&
                c >= 0 &&
                precision >= 2 &&
                precision <= 8
                ))
            {
                throw new ArgumentOutOfRangeException("wrong arguments");
            }
            if (!(
                a + b >= c &&
                a + c >= b &&
                c + b >= a
                ))
            {
                Console.WriteLine("object not exist");
                throw new ArgumentOutOfRangeException("object not exist");
            }

            double results = a + b + c;

            results = Math.Round(results, precision);

            return results;
        }
    }
}