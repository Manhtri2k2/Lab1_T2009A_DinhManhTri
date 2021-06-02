using System;

namespace Exercise4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please enter the number: ");
                int number = Int32.Parse(Console.ReadLine());
                for (int i = 1; i < 10; i++)
                {
                    int value = number * i;
                    Console.WriteLine($"{number} * {i} = {value}");
                }
                
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}