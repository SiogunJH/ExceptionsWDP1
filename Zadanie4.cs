using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie4
    {
        public static void Main()
        {
            //Read input
            double[] userInput = Array.ConvertAll(Console.ReadLine().Split(' '), el => Convert.ToDouble(el));

            //Wrong args
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] < 0)
                {
                    Console.WriteLine("ujemny argument");
                    return;
                }
                if (userInput[i] > Math.Pow(10, 6))
                {
                    Console.WriteLine("argument poza zakresem");
                    return;
                }
            }


            //Bad args
            double r = userInput[0];
            double l = userInput[1];
            if (l < r)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            //Execute
            //v = (r^2*PI) * h
            //h^2 + r^2 = l^2
            //h = _/( l^2 - r^2 )
            //v = (1/3)*r^2*PI*_/(l^2-r^2)
            double volume = ((double)1 / (double)3) * Math.Pow((double)r, 2) * Math.PI * Math.Sqrt(Math.Pow((double)l, 2) - Math.Pow((double)r, 2));

            //Testfield
            //707106
            //1000000

            // string temp;
            // temp = String.Format("(1/3) * {0}^2 * {2} * _/( {1}^2 - {0}^2 )", r, l, 3.14);
            // Console.WriteLine(temp);
            // temp = String.Format("(1/3) * {0} * {2} * _/( {1} - {0} )", Math.Pow(r, 2), Math.Pow(l, 2), 3.14);
            // Console.WriteLine(temp);
            // temp = String.Format("(1/3) * {0} * _/( {1} )", Math.Pow(r, 2) * 3.14, Math.Pow(l, 2) - Math.Pow(r, 2));
            // Console.WriteLine(temp);
            // temp = String.Format("{0:F2} * {1:F2}", Math.Pow(r, 2) * 3.14 / 3, Math.Sqrt(Math.Pow(l, 2) - Math.Pow(r, 2)));
            // Console.WriteLine(temp);
            // temp = String.Format("{0:F2}", Math.Pow(r, 2) * 3.14 / 3 * (Math.Sqrt(Math.Pow(l, 2) - Math.Pow(r, 2))));
            // Console.WriteLine(temp);

            //Find limits
            double a = Math.Floor(volume);
            double b = Math.Ceiling(volume);

            Console.WriteLine(String.Format("{0} {1}",
            a.ToString("F").Substring(0, a.ToString("F").Length - 3),
            b.ToString("F").Substring(0, b.ToString("F").Length - 3)
            ));
        }
    }
}