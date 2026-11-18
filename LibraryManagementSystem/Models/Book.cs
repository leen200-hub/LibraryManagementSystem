using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models.Interfaces;
using System.Text.Json.Serialization;
using LibraryManagementSystem.Attributes;
using System.Reflection;
namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Represents a book in the library system.
    /// </summary>
    [BookCategory("Programming")]
    public  class Book : IBorrowable
    {
        /// <summary>
        /// Gets or sets the unique identifier of the book.
        /// </summary>

        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string ISBN { get; set; } = string.Empty;
        [JsonInclude]
        /// <summary>
        /// Gets a value indicating whether the book is available for borrowing.
        /// </summary>
        
        public bool IsAvailable { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Book class.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="isbn">The ISBN of the book.</param>
        public Book(int id, string title, string author, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true;
        }
        /// <summary>
        /// Borrows the book for a specified member.
        /// </summary>
        /// <param name="member">The member who wants to borrow the book.</param>
        public void Borrow(Member member)
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                BorrowedBy = member;
                Console.WriteLine("Book borrowed successfully!");
            }
            else
            {
                Console.WriteLine("Book is not available!");
            }
        }
        /// <summary>
        /// Returns the borrowed book to the library.
        /// </summary>
        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine("Book returned successfully!");
                BorrowedBy = null;
            }
            else
            {
                Console.WriteLine("Book is already available!");
            }

        }
        [JsonInclude]
        /// <summary>
        /// Gets the member who currently borrowed the book.
        /// </summary>
        public Member? BorrowedBy { get; private set; }
    }
}

