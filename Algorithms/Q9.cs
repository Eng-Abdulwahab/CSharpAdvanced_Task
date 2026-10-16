using System;

namespace CSharpAdvanced_Task.Algorithms
{
    public class Q9
    {
        /*
          Optimized Bubble Sort:
          1) Early exit: if a full pass makes no swap, the array is already sorted,
             so we stop. Best case becomes O(n) instead of O(n^2).
          2) Shrinking range: after pass i, the last i elements are already in their
             final place, so the inner loop stops at n - i - 1.
          Worst / average case is still O(n^2), O(1) extra space.
         */
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