using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your three numbers: ");
                int number1 = Int32.Parse(Console.ReadLine());
                int number2 = Int32.Parse(Console.ReadLine());
                int number3 = Int32.Parse(Console.ReadLine());
                if (number1 >= number2 && number1 >= number3)
                {
                    Console.WriteLine("The largest number is: " + number1);
                }
                else if (number2 >= number3) {
                    Console.WriteLine("The largest number is: " + number2);
                }
                else 
                {
                    Console.WriteLine("The largest number is: " + number3);
                }
            
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}