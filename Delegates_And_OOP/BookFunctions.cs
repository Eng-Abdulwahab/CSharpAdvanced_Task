using System;

namespace CSharpAdvanced_Task.Delegates_And_OOP
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return B.Authors != null ? string.Join(", ", B.Authors) : "Unknown";
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }

        public static string GetISBN(Book B)
        {
            return B.ISBN;
        }

        public static string GetPublicationDate(Book B)
        {
            return B.PublicationDate.ToShortDateString();
        }
    }
}