using System;
using System.Collections.Immutable;
using System.Globalization;

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

        
        private static int CountGreaterThanX(int[] sorted,int x)
        {
            int low = 0, high = sorted.Length;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (sorted[mid] <= x)
                    low = mid + 1;
                else
                    high = mid;
            }

            return sorted.Length - low;
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