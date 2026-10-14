using System;
using System.Collections.Generic;

namespace CSharpAdvanced_Task.Stack_And_Queue
{
    public class Q7
    {
        public static void ReverseQueueWithStack(Queue<int> queue)
        {
            if (queue == null) return;

            Stack<int> stack = new Stack<int>();

            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                stack.Push(queue.Dequeue());
            }

            for (int i = 0; i < size; i++)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    }
}
