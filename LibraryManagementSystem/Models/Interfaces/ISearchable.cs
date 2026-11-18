using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models.Interfaces
{
    /// <summary>
    /// Defines a method for searching books in the library.
    /// </summary>
    public interface  ISearchable
    {
        /// <summary>
        /// Searches for a book using its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The book if found; otherwise, null.</returns>
        Book? SearchBook(int id);
    }
}
