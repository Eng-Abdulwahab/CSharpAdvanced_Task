using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Task.Collections
{
    public class Q5
    {
        public static int[] RemoveDuplicates(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return Array.Empty<int>();

            Array.Sort(arr);

            List<int> list = new List<int>() { arr[0] };
            

            for (int i = 1; i < arr.Length; i++)
            {    
                if (arr[i] != arr[i - 1])
                    list.Add(arr[i]);                           
            }

            return list.ToArray();
        }
    }
}