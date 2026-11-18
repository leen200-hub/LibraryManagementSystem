using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Exceptions
{
    /// <summary>
    /// Represents an exception thrown when a requested book is not found.
    /// </summary>
    public class BookNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the BookNotFoundException class.
        /// </summary>
        /// <param name="message">The error message describing why the book was not found.</param>
        public BookNotFoundException(string message)
            : base(message)
        {
        }
    }
}