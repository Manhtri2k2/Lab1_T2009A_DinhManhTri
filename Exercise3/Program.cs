using System;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int number;

                Console.Write("Input number: ");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Monday.");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday.");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday.");
                        break;
                    case 4:
                        Console.WriteLine("Thursday.");
                        break;
                    case 5:
                        Console.WriteLine("Friday.");
                        break;
                    case 6:
                        Console.WriteLine("Saturday.");
                        break;
                    case 7:
                        Console.WriteLine("Sunday.");
                        break;
                    default:
                        Console.WriteLine("Please try again...");
                        break;
                }
                Console.WriteLine("Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}