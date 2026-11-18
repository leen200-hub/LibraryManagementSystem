using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Represents a delegate for handling book borrowing events.
    /// </summary>
    public delegate void BookBorrowedHandler(string bookTitle, string memberName);
}

