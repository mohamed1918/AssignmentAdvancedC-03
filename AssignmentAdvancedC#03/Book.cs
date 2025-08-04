using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAdvancedC_03
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, ISBN: {ISBN}, Published: {PublicationDate.ToShortDateString()}";
        }
    }
}
