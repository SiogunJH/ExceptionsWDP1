using System;

namespace TabliceWielowymiaroweZestawWDP1
{
    class Zadanie2
    {
        public static void Main2()
        {
            try
            {
                int results = Execute();
                Console.WriteLine(results);
            }
            catch (FormatException)
            {
                Console.WriteLine("format exception, exit");
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception, exit");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("argument exception, exit");
            }
        }
        public static int Execute()
        {
            int[] userInput = new int[3];
            string temp;

            for (int i = 0; i < userInput.Length; i++)
            {
                temp = Console.ReadLine();

                if (temp == "")
                {
                    throw new ArgumentException();
                }

                checked
                {
                    userInput[i] = int.Parse(temp);
                }
            }


            int results = 1;
            for (int i = 0; i < userInput.Length; i++)
            {
                checked
                {
                    results *= userInput[i];
                }
            }
            return results;
        }
    }
}