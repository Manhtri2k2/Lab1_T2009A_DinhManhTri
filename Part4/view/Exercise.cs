using System;

namespace Part4.view
{
    public class Exercise
    {
        public void Ex1()
        {
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter your address: ");
            String address = Console.ReadLine();
            Console.WriteLine("Please enter your phone: ");
            int phone = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your information");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
        }
        
        public void Ex2()
        {
            int a = 1;
            int b = 5;
            int c = 3;
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        
        public void Ex3()
        {
            Console.WriteLine("Please enter your choise: ");
            Console.WriteLine("1. Monday.");
            Console.WriteLine("2. Tuesday.");
            Console.WriteLine("3. Wednesday.");
            Console.WriteLine("4. Thursday.");
            Console.WriteLine("5. Friday.");
            Console.WriteLine("6. Saturday.");
            Console.WriteLine("7. Sunday.");
            int choise = Int32.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter 1-7");
                    break;
            }
            
        }
        
        
        public void Ex4()
        {
            Console.WriteLine("Please enter the number: ");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int value = number * i;
                Console.WriteLine($"{number} * {i} = {value}");
            }
        }

        public void Ex5()
        {
            int i, f=1, number;
            Console.WriteLine("Calculate the factorial:\n");
            Console.WriteLine("----------");

            Console.WriteLine("Please input number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            { 
                f = f * i;
            }

            Console.WriteLine("Factorial of "+ number+ "\nis:" + f);

        }

    }
}