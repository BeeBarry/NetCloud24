// This is a library system program that manages books, loanees and loans in a library.

public class Library
{
    private List<Book> Books { get; } = new List<Book>();
    private List<LibraryUser> Users { get; } = new List<LibraryUser>();



    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddUser(LibraryUser user)
    {
        Users.Add(user);
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Books available");
        foreach (var book in Books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN})");
        }

        Console.WriteLine("\nLibrary Users:");
        foreach (var user in Users)
        {
            Console.WriteLine($"- {user.Name} (ID: {user.UserId})");
        }
        
    }


}

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    public class LibraryUser
    {
        public string Name { get; set; }
        public string UserId { get; set; }
    }

    public class Loan
    {
        public Book LoanedBook { get; set; }
        public LibraryUser Loanee { get; set; }
    }


