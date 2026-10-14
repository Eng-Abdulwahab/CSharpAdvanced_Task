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
                Console.WriteLine("16-17. Test Q17: Custom Delegate (GetTitle)");
                Console.WriteLine("18. Test Q18: Built-in Delegate Func (GetPrice)");
                Console.WriteLine("19. Test Q19: Anonymous Method (GetAuthors)");
                Console.WriteLine("20. Test Q20: Lambda Expression (PublicationDate)");
                Console.WriteLine("0. Exit");
                Console.WriteLine("========================================");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

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
                        Console.WriteLine("Exiting program. Good luck with the task!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }

                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }

        private static void RunQ1()
        {
            Console.WriteLine("--- Testing Q1: ArrayList Reverse (In-Place) ---");
            ArrayList list = new ArrayList { 10, 20, 30, 40, 50 };

            Console.Write("Before Reverse: ");
            foreach (var item in list) Console.Write(item + " ");
            Console.WriteLine();

            Q1.Reverse(list);

            Console.Write("After Reverse: ");
            foreach (var item in list) Console.Write(item + " ");
            Console.WriteLine();
        }

        private static void RunQ2()
        {
            Console.WriteLine("--- Testing Q2: Even Numbers Filter ---");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Original List: ");
            foreach (var item in numbers) Console.Write(item + " ");
            Console.WriteLine();

            List<int> evens = Q2.GetEvenList(numbers);

            Console.Write("Even List: ");
            foreach (var item in evens) Console.Write(item + " ");
            Console.WriteLine();
        }

        private static void RunQ4()
        {
            Console.WriteLine("--- Testing Q4: Check Array Palindrome ---");
            bool result = Q4.IsPalindrome();
            Console.WriteLine($"\nIs Palindrome? -> {result}");
        }

        private static void RunQ5()
        {
            Console.WriteLine("--- Testing Q5: Remove Duplicates ---");
            int[] arr = { 5, 2, 9, 5, 2, 3, 1, 9 };

            Console.Write("Original Array: ");
            foreach (var item in arr) Console.Write(item + " ");
            Console.WriteLine();

            int[] uniqueArr = Q5.RemoveDuplicates(arr);

            Console.Write("Unique Array: ");
            foreach (var item in uniqueArr) Console.Write(item + " ");
            Console.WriteLine();
        }

        private static void RunQ6()
        {
            Console.WriteLine("--- Testing Q6: Remove Odd Numbers (In-Place) ---");
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Before Removal: ");
            foreach (var item in list) Console.Write(item + " ");
            Console.WriteLine();

            Q6.RemoveOdd(list);

            Console.Write("After Removal: ");
            foreach (var item in list) Console.Write(item + " ");
            Console.WriteLine();
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

            Console.Write("Original Queue: ");
            foreach (var item in queue) Console.Write(item + " ");
            Console.WriteLine();

            Q7.ReverseQueueWithStack(queue);

            Console.Write("Reversed Queue: ");
            foreach (var item in queue) Console.Write(item + " ");
            Console.WriteLine();
        }

        private static void RunQ8()
        {
            Console.WriteLine("--- Testing Q8: Check Balanced Parentheses ---");
            string test1 = "[()]{}";
            string test2 = "([)]";

            Console.WriteLine($"Input: {test1} -> Is Balanced? {Q8.IsBalanced(test1)}");
            Console.WriteLine($"Input: {test2} -> Is Balanced? {Q8.IsBalanced(test2)}");
        }

        private static void RunQ9()
        {
            Console.WriteLine("--- Testing Q9: Bubble Sort ---");
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.Write("Before Sorting: ");
            foreach (var item in arr) Console.Write(item + " ");
            Console.WriteLine();

            Q9.BubbleSort(arr);

            Console.Write("After Bubble Sort: ");
            foreach (var item in arr) Console.Write(item + " ");
            Console.WriteLine();
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

            try
            {
                list.Add("D");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            try
            {
                Console.WriteLine(list[5]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        private static void RunRangeTests()
        {
            Console.WriteLine("--- Testing Q13-Q15: Range<T> with Integers ---");

            Range<int> intRange = new Range<int>(10, 50);
            Console.WriteLine("Range created with Min: 10, Max: 50");
            Console.WriteLine($"Is 25 in range? {intRange.IsInRange(25)}");
            Console.WriteLine($"Is 55 in range? {intRange.IsInRange(55)}");
            Console.WriteLine($"Range Length: {intRange.Length()}");

            try
            {
                Range<int> invalidRange = new Range<int>(60, 20);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine("\n--- Testing Range<T> with Strings ---");
            Range<string> stringRange = new Range<string>("A", "Z");
            Console.WriteLine("String Range created with Min: A, Max: Z");
            Console.WriteLine($"Is 'M' in range? {stringRange.IsInRange("M")}");
            Console.WriteLine($"Is 'a' in range? {stringRange.IsInRange("a")}");

            try
            {
                var len = stringRange.Length();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
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
            Console.WriteLine("--- Testing Q19: Anonymous Method (GetAuthors) ---");
            var books = GetSampleBooks();
            LibraryEngine.ProcessBooks(books, delegate (Book B) {
                return B.Authors != null ? string.Join(" & ", B.Authors) : "No Author";
            });
        }

        private static void RunDelegateQ20()
        {
            Console.WriteLine("--- Testing Q20: Lambda Expression (PublicationDate) ---");
            var books = GetSampleBooks();
            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToShortDateString());
        }
    }
}