using System;
using System.Collections.Immutable;

namespace CSharpAdvanced_Task.Collections
{
    public class Q3
    {
        public static void Solve()
        {
            Console.Write("Enter array size: ");
            int arraySize = ReadInt();

            Console.Write("Enter elements of the array: ");
            int[] arr = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = ReadInt();
            }

            Array.Sort(arr);

            Console.Write("Enter the number of queries: ");
            int queriesNumber = ReadInt();

            int[] results = new int[queriesNumber];

            for (int i = 0; i < queriesNumber; i++)
            {
                Console.Write($"Enter Query {i + 1} (Value of X): ");
                int x = ReadInt();

                results[i] = CountGreaterThanX(arr, x);
            }

            Console.WriteLine("\n--- Results ---");
            for (int i = 0; i < queriesNumber; i++)
            {
                Console.WriteLine($"Result for Query {i + 1}: {results[i]}");
            }
        }

        
        private static int CountGreaterThanX(int[] arr,int x)
        {
            int index = Array.BinarySearch(arr, x);

            if (index < 0)
            {
                index = ~index;
            }
            else
            {
                while (index < arr.Length && arr[index] == x)
                {
                    index++;
                }
            }

            return arr.Length - index;
        }



        private static int ReadInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                    return number;
                else
                    Console.Write("Invalid input. Please enter a valid integer: ");
            }
        }
    }
}