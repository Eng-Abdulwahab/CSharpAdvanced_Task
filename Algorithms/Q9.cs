using System;

namespace CSharpAdvanced_Task.Algorithms
{
    public class Q9
    {
        // Stops early if no swaps happen in a pass (best case O(n), worst O(n^2))
        public static void BubbleSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}