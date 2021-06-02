using System;

namespace ValueType
{
    internal class Example
    {
        public static void Main(string[] args)
        {
            int valueVal = 5;
            Test(valueVal);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();

        }

        private static void Test(int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;
        }
    }
}