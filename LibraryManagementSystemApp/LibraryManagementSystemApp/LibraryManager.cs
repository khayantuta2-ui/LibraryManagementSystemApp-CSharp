using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    // Class to manage library operations
    public class LibraryManager
    {
        // In-memory lists to store books and members
        private List<Book> books;
        private List<Member> members;
        private List<Librarian> librarians;

        // Public properties with encapsulation
        public List<Book> Books
        {
            get { return books; }
        }

        public List<Member> Members
        {
            get { return members; }
        }

        public List<Librarian> Librarians
        {
            get { return librarians; }
        }

        // Constructor to initialize lists
        public LibraryManager()
        {
            books = new List<Book>();
            members = new List<Member>();
            librarians = new List<Librarian>();
            InitializeData();
        }

        // Method to add sample data for testing
        private void InitializeData()
        {
            // Add default librarian
            librarians.Add(new Librarian(1, "Admin", "admin123"));

            // Add sample books
            books.Add(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald"));
            books.Add(new Book(2, "To Kill a Mockingbird", "Harper Lee"));
            books.Add(new Book(3, "1984", "George Orwell"));

            // Add sample member
            members.Add(new Member(1, "Charlie Mayham", "Mayham123", DateTime.Now));
        }

        // Method to add a new book
        public void AddBook(int id, string title, string author)
        {
            Book newBook = new Book(id, title, author);
            books.Add(newBook);
        }

        // Method to add a new member
        public void AddMember(int id, string name, string password)
        {
            Member newMember = new Member(id, name, password, DateTime.Now);
            members.Add(newMember);
        }

        // Method to search books by title or author
        public List<Book> SearchBooks(string searchTerm)
        {
            return books.Where(b => b.Title.ToLower().Contains(searchTerm.ToLower()) ||
                                    b.Author.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        // Method to get all books
        public List<Book> GetAllBooks()
        {
            return books;
        }

        // Method to get all members
        public List<Member> GetAllMembers()
        {
            return members;
        }

        // Method to find a book by ID
        public Book FindBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        // Method to find a member by ID
        public Member FindMemberById(int id)
        {
            return members.FirstOrDefault(m => m.Id == id);
        }

        // Method to authenticate librarian
        public Librarian AuthenticateLibrarian(string name, string password)
        {
            return librarians.FirstOrDefault(l => l.Name == name && l.Password == password);
        }

        // Method to authenticate member
        public Member AuthenticateMember(string name, string password)
        {
            return members.FirstOrDefault(m => m.Name == name && m.Password == password);
        }

        // Method to get next available book ID
        public int GetNextBookId()
        {
            return books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
        }

        // Method to get next available member ID
        public int GetNextMemberId()
        {
            return members.Count > 0 ? members.Max(m => m.Id) + 1 : 1;
        }
    }
}