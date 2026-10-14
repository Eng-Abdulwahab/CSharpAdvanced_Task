using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Task.Collections
{
    public class Q4
    {
        public static bool IsPalindrome()
        {
            Console.Write("Enter array size: ");
            int size = ReadInt();

            int[] arr = new int[size];

            Console.Write("Enter elements of the array: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = ReadInt();
            }

            int left = 0;
            int right = size - 1;
            

            while(left < right)
            {
                if (arr[left] != arr[right])
                    return false;

                left++;
                right--;
            }

            return true;
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
