using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAdvancedC_03
{
    public class BookFunctions
    {
        public static string GetTitle(Book b) => b.Title;
        public static string GetISBN(Book b) => b.ISBN;
        public static string GetPublicationDate(Book b) => b.PublicationDate.ToShortDateString();
    }
}
