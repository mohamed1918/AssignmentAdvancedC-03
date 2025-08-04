namespace AssignmentAdvancedC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            List<Book> library = new List<Book>
            {
                new Book { Title="C# in Depth", ISBN="123-456", PublicationDate=new DateTime(2020,2,20)},
                new Book { Title="ASP.NET Core", ISBN="654-321", PublicationDate=new DateTime(2021,9,1)}
            };


            Console.WriteLine(" User Defined Delegate ");
            LibraryEngine.ProcessBooks_UserDefined(library, BookFunctions.GetTitle);


            Console.WriteLine("\n BCL Delegates ");
            LibraryEngine.ProcessBooks_BCL(library, BookFunctions.GetISBN);


            Console.WriteLine("\nAnonymous Method ");
            LibraryEngine.ProcessBooks_Anonymous(library);


            Console.WriteLine("\n Lambda Expression ");
            LibraryEngine.ProcessBooks_Lambda(library);
            #endregion
        }
    }
   
}
