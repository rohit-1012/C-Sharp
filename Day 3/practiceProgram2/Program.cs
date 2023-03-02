using System;

namespace practiceProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            string ?str;
            int[] arr = new int[10];
            Console.WriteLine("Enter an Integer value:");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a String: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter any 10 Numbers: ");
            for (int i = 0; i <= 9; i++)
            {
                int val;
                val = Convert.ToInt16(Console.ReadLine());
                arr[i] = val;
            }

            Console.WriteLine($"Integer Value Entered: {x}, \nString Entered: {str},");
            Console.Write("Array of 10 Numbers Entered: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.ReadLine();
        }
    }
}