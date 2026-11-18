using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.Interfaces
{
    /// <summary>
    /// Defines methods for borrowing and returning books.
    /// </summary>
    public interface IBorrowable
    {
        /// <summary>
        /// Borrows a book for the specified member.
        /// </summary>
        /// <param name="member">The member who wants to borrow the book.</param>
        void Borrow(Member member);
        /// <summary>
        /// Returns a borrowed book to the library.
        /// </summary>
        void ReturnBook();
    }
}
