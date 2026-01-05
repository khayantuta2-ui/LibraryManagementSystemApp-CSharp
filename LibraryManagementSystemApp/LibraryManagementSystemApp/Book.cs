using System;
using System.Text;

namespace LibraryManagementSystem
{
    // Book class to represent library books
    public class Book
    {
        // Private fields with public properties for encapsulation
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor to initialize a new book
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = true; // Books are available by default
        }

        // Method to format book details using StringBuilder
        public string GetBookDetails()
        {
            StringBuilder details = new StringBuilder();
            details.Append("ID: ").Append(Id);
            details.Append(" | Title: ").Append(Title);
            details.Append(" | Author: ").Append(Author);
            details.Append(" | Status: ").Append(IsAvailable ? "Available" : "Borrowed");
            return details.ToString();
        }

        // Override ToString for easy display
        public override string ToString()
        {
            return GetBookDetails();
        }
    }
}