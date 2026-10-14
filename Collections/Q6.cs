using System;
using System.Collections;

namespace CSharpAdvanced_Task.Collections
{
    public class Q6
    {
        public static void RemoveOdd(ArrayList list)
        {
            if (list == null) return;

            
            for (int i = list.Count - 1; i >= 0; i--) // To avoid index shifting problem
            {                
                if (list[i] is int num && num % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
