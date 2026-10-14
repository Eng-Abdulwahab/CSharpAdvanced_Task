using System;
using System.Collections.Generic;

namespace CSharpAdvanced_Task.Collections
{
    public class Q2
    {
        public static List<int> GetEvenList(List<int> list)
        {
            List<int> EvenList = new List<int>();

            foreach (int i in list)
            {
                if (i % 2 == 0)
                    EvenList.Add(i);
            }

            return EvenList;
        }
    }
}