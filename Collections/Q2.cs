using System;
using System.Collections.Generic;

namespace CSharpAdvanced_Task.Collections
{
    public class Q2
    {
        public static List<int> GetEvenList(List<int> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));

            List<int> evenList = new List<int>();
            foreach (int number in list)
            {
                if (number % 2 == 0)
                    evenList.Add(number);
            }
            return evenList;
        }
    }
}