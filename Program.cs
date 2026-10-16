using System;
using System.Collections;
using System.Collections.Generic;
using CSharpAdvanced_Task.Algorithms;
using CSharpAdvanced_Task.Collections;
using CSharpAdvanced_Task.Delegates_And_OOP;
using CSharpAdvanced_Task.Generics;
using CSharpAdvanced_Task.Stack_And_Queue;

namespace CSharpAdvanced_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("    C# Advanced Tasks - Complete Menu   ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Test Q1: Reverse ArrayList In-Place");
                Console.WriteLine("2. Test Q2: Filter Even Numbers");
                Console.WriteLine("3. Test Q3: Count Elements Greater Than X");
                Console.WriteLine("4. Test Q4: Check Array Palindrome");
                Console.WriteLine("5. Test Q5: Remove Duplicates");
                Console.WriteLine("6. Test Q6: Remove Odd Numbers (In-Place)");
                Console.WriteLine("7. Test Q7: Reverse Queue using Stack");
                Console.WriteLine("8. Test Q8: Check Balanced Parentheses");
                Console.WriteLine("9. Test Q9: Bubble Sort");
                Console.WriteLine("10-12. Test Q10-Q12: FixedSizeList<T>");
                Console.WriteLine("13-15. Test Q13-Q15: Range<T>");
                Console.WriteLine("16. Test Q16: Book & BookFunctions");
                Console.WriteLine("17. Test Q17: Custom Delegate (GetTitle)");
                Console.WriteLine("18. Test Q18: Built-in Delegate Func (GetPrice)");
                Console.WriteLine("19. Test Q19: Anonymous Method (GetISBN)");
                Console.WriteLine("20. Test Q20: Lambda Expression (GetPublicationDate)");
                Console.WriteLine("0. Exit");
                Console.WriteLine("========================================");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            RunQ1();
                            break;
                        case "2":
                            RunQ2();
                            break;
                        case "3":
                            Q3.Solve();
                            break;
                        case "4":
                            RunQ4();
                            break;
                        case "5":
                            RunQ5();
                            break;
                        case "6":
                            RunQ6();
                            break;
                        case "7":
                            RunQ7();
                            break;
                        case "8":
                            RunQ8();
                            break;
                        case "9":
                            RunQ9();
                            break;
                        case "10":
                        case "11":
                        case "12":
                            RunFixedSizeListTests();
                            break;
                        case "13":
                        case "14":
                        case "15":
                            RunRangeTests();
                            break;
                        case "16":
                            RunQ16();
                            break;
                        case "17":
                            RunDelegateQ17();
                            break;
                        case "18":
                            RunDelegateQ18();
                            break;
                        case "19":
                            RunDelegateQ19();
                            break;
                        case "20":
                            RunDelegateQ20();
                            break;
                        case "0":
                            Console.WriteLine("Exiting program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice! Please enter a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong: {ex.Message}");
                }

                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }

        // Prints a label followed by all items of any collection
        private static void PrintItems(string label, IEnumerable items)
        {
            Console.Write(label);
            foreach (var item in items) Console.Write(item + " ");
            Console.WriteLine();
        }

        private static void RunQ1()
        {
            Console.WriteLine("--- Testing Q1: ArrayList Reverse (In-Place) ---");
            ArrayList list = new ArrayList { 10, 20, 30, 40, 50 };

            PrintItems("Before Reverse: ", list);
            Q1.Reverse(list);
            PrintItems("After Reverse: ", list);
        }

        private static void RunQ2()
        {
            Console.WriteLine("--- Testing Q2: Even Numbers Filter ---");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintItems("Original List: ", numbers);
            PrintItems("Even List: ", Q2.GetEvenList(numbers));
        }

        private static void RunQ4()
        {
            Console.WriteLine("--- Testing Q4: Check Array Palindrome ---");
            bool result = Q4.IsPalindrome();
            Console.WriteLine($"\nIs Palindrome? -> {(result ? "YES" : "NO")}");
        }

        private static void RunQ5()
        {
            Console.WriteLine("--- Testing Q5: Remove Duplicates ---");
            int[] arr = { 5, 2, 9, 5, 2, 3, 1, 9 };

            PrintItems("Original Array: ", arr);
            PrintItems("Unique Array: ", Q5.RemoveDuplicates(arr));
        }

        private static void RunQ6()
        {
            Console.WriteLine("--- Testing Q6: Remove Odd Numbers (In-Place) ---");
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintItems("Before Removal: ", list);
            Q6.RemoveOdd(list);
            PrintItems("After Removal: ", list);
        }

        private static void RunQ7()
        {
            Console.WriteLine("--- Testing Q7: Reverse Queue using Stack ---");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            PrintItems("Original Queue: ", queue);
            Q7.ReverseQueueWithStack(queue);
            PrintItems("Reversed Queue: ", queue);
        }

        private static void RunQ8()
        {
            Console.WriteLine("--- Testing Q8: Check Balanced Parentheses ---");
            string[] tests = { "[()]{}", "([)]" };

            foreach (string test in tests)
            {
                string result = Q8.IsBalanced(test) ? "Balanced" : "Not Balanced";
                Console.WriteLine($"Input: \"{test}\" -> {result}");
            }
        }

        private static void RunQ9()
        {
            Console.WriteLine("--- Testing Q9: Bubble Sort ---");
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            PrintItems("Before Sorting: ", arr);
            Q9.BubbleSort(arr);
            PrintItems("After Bubble Sort: ", arr);
        }

        private static void RunFixedSizeListTests()
        {
            Console.WriteLine("--- Testing Q10-Q12: FixedSizeList<T> ---");

            FixedSizeList<string> list = new FixedSizeList<string>(3);
            Console.WriteLine($"Capacity created: {list.Capacity}");

            list.Add("A");
            list.Add("B");
            list.Add("C");
            Console.WriteLine("Added 3 elements successfully.");

            Console.WriteLine($"Element at index 1: {list.Get(1)}");
            Console.WriteLine($"Element at index 2 (Indexer): {list[2]}");
        }

        private static void RunRangeTests()
        {
            Console.WriteLine("--- Testing Q13-Q15: Range<T> ---");

            Range<int> intRange = new Range<int>(10, 50);
            Console.WriteLine("Range created with Min: 10, Max: 50");
            Console.WriteLine($"Is 25 in range? {intRange.IsInRange(25)}");
            Console.WriteLine($"Is 55 in range? {intRange.IsInRange(55)}");
            Console.WriteLine($"Range Length: {intRange.Length()}");
        }

        private static List<Book> GetSampleBooks()
        {
            return new List<Book>
            {
                new Book("123-456", "C# Advanced Programming", new string[] { "Ahmed", "Ali" }, new DateTime(2025, 3, 15), 250.0m),
                new Book("789-101", "Clean Architecture", new string[] { "Mohamed" }, new DateTime(2024, 11, 10), 300.5m),
                new Book("112-233", "Design Patterns in C#", new string[] { "Khaled", "Omar" }, new DateTime(2023, 6, 20), 180.0m)
            };
        }

        private static void RunQ16()
        {
            Console.WriteLine("--- Testing Q16: Book & BookFunctions ---");
            Book book = GetSampleBooks()[0];

            Console.WriteLine($"ToString(): {book}");
            Console.WriteLine($"GetTitle: {BookFunctions.GetTitle(book)}");
            Console.WriteLine($"GetAuthors: {BookFunctions.GetAuthors(book)}");
            Console.WriteLine($"GetPrice: {BookFunctions.GetPrice(book)}");
            Console.WriteLine($"GetISBN: {BookFunctions.GetISBN(book)}");
            Console.WriteLine($"GetPublicationDate: {BookFunctions.GetPublicationDate(book)}");
        }

        private static void RunDelegateQ17()
        {
            Console.WriteLine("--- Testing Q17: Custom Delegate (GetTitle) ---");
            var books = GetSampleBooks();
            LibraryEngine.ProcessBooksCustom(books, BookFunctions.GetTitle);
        }

        private static void RunDelegateQ18()
        {
            Console.WriteLine("--- Testing Q18: Built-in Delegate Func (GetPrice) ---");
            var books = GetSampleBooks();
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
        }

        private static void RunDelegateQ19()
        {
            Console.WriteLine("--- Testing Q19: Anonymous Method (GetISBN) ---");
            var books = GetSampleBooks();
            LibraryEngine.ProcessBooks(books, delegate (Book B)
            {
                return B.ISBN;
            });
        }

        private static void RunDelegateQ20()
        {
            Console.WriteLine("--- Testing Q20: Lambda Expression (GetPublicationDate) ---");
            var books = GetSampleBooks();
            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToShortDateString());
        }
    }
}