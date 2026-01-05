using System;

namespace LibraryManagementSystem
{
    // Custom exception for when a book is not available
    public class BookNotAvailableException : Exception
    {
        // Default constructor
        public BookNotAvailableException() : base("The requested book is not available.")
        {
        }

        // Constructor with custom message
        public BookNotAvailableException(string message) : base(message)
        {
        }

        // Constructor with custom message and inner exception
        public BookNotAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}