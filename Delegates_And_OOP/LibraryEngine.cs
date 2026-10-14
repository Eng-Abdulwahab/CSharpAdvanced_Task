using System;
using System.Collections.Generic;

namespace CSharpAdvanced_Task.Delegates_And_OOP
{
    public delegate string BookFunctionDelegate(Book B);

    public class LibraryEngine
    {
        public static void ProcessBooksCustom(List<Book> bList, BookFunctionDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}