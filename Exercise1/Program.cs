using System;

namespace Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Please enter your phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Personal information: ");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Address: " + address);
                Console.WriteLine("Phone number: " + phoneNumber);

                Console.WriteLine("Enter to continue...");
                Console.ReadLine();

            }
        }
    }
}