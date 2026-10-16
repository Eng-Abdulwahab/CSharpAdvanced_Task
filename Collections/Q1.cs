using System;
using System.Collections;

namespace CSharpAdvanced_Task.Collections
{
    public class Q1
    {
        public static void Reverse(ArrayList list)
        {
            if (list == null || list.Count < 2) return;

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                var temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}