using System;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double factorial;
            int index = 1;
            int counter = 0;

            Console.WriteLine("Number\t Factorial");
            while (index <= 20)
            {
                factorial = 1;
                counter = index;
                while (counter > 0)
                {
                    factorial *= counter;
                    counter--;
                }

                Console.WriteLine(index + "\t" + factorial);
                index++;
            }

            Console.ReadLine();
        }
    }
}