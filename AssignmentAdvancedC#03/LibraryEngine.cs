using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAdvancedC_03
{
    //  User Defined Delegate
    public delegate string BookDelegate(Book book);

    public class LibraryEngine
    {
        //  User Defined Delegate
        public static void ProcessBooks_UserDefined(List<Book> books, BookDelegate fPtr)
        {
            foreach (var book in books)
                Console.WriteLine(fPtr(book));
        }

        //  BCL Delegate - Func
        public static void ProcessBooks_BCL(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var book in books)
                Console.WriteLine(fPtr(book));
        }

        //  Anonymous Method
        public static void ProcessBooks_Anonymous(List<Book> books)
        {
            Func<Book, string> getISBN = delegate (Book b)
            {
                return b.ISBN;
            };

            foreach (var book in books)
                Console.WriteLine(getISBN(book));
        }

        // Lambda Expression
        public static void ProcessBooks_Lambda(List<Book> books)
        {
            Func<Book, string> getDate = b => b.PublicationDate.ToShortDateString();

            foreach (var book in books)
                Console.WriteLine(getDate(book));
        }
    }
}
