using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    // Abstract base class for all users
    public abstract class User
    {
        // Private fields with protected access for derived classes
        private int id;
        private string name;
        private string password;

        // Public properties with encapsulation
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Constructor
        protected User(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        // Abstract method for polymorphism - must be implemented by derived classes
        public abstract string GetRole();
    }

    // Librarian class derived from User
    public class Librarian : User
    {
        // Constructor
        public Librarian(int id, string name, string password) : base(id, name, password)
        {
        }

        // Polymorphic implementation of GetRole
        public override string GetRole()
        {
            return "Librarian - Can manage books and members";
        }
    }

    // Member class derived from User
    public class Member : User
    {
        // Member-specific fields
        private DateTime joinDate;
        private List<Book> borrowedBooks;

        // Public properties
        public DateTime JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }

        public List<Book> BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }

        // Constructor
        public Member(int id, string name, string password, DateTime joinDate) : base(id, name, password)
        {
            this.joinDate = joinDate;
            this.borrowedBooks = new List<Book>();
        }

        // Polymorphic implementation of GetRole
        public override string GetRole()
        {
            return "Member - Can borrow and return books";
        }

        // Method to borrow a book
        public void BorrowBook(Book book)
        {
            if (!book.IsAvailable)
            {
                throw new BookNotAvailableException("This book is currently unavailable.");
            }
            borrowedBooks.Add(book);
            book.IsAvailable = false;
        }

        // Method to return a book
        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                book.IsAvailable = true;
            }
        }
    }
}