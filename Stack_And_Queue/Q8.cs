using System;
using System.Collections.Generic;

namespace CSharpAdvanced_Task.Stack_And_Queue
{
    public class Q8
    {
        public static bool IsBalanced(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {                
                if (c is '{' or '(' or '[')
                {
                    stack.Push(c);
                }
                else if (c is '}' or ')' or ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char topElement = stack.Pop();
                    
                    if ((c == ')' && topElement != '(') ||
                        (c == '}' && topElement != '{') ||
                        (c == ']' && topElement != '['))
                    {
                        return false;
                    }
                }
            }

            
            return stack.Count == 0;
        }
    }
}