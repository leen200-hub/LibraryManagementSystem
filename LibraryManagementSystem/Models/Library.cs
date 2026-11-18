using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models.Interfaces;
using LibraryManagementSystem.Exceptions;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Manages the library books and borrowing operations.
    /// </summary>
    public class Library : ISearchable
        {/// <summary>
           /// Occurs when a book is successfully borrowed by a member.
          /// </summary>
        public event BookBorrowedHandler? OnBookBorrowed;
        private List<Book> books = new List<Book>();
        /// <summary>
        /// Adds a new book to the library.
        /// </summary>
        /// <param name="book">The book to be added.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the book ID is less than or equal to zero.
        /// </exception>
        public void AddBook(Book book)
            {
            if (book.Id <= 0)
            {
                throw new ArgumentException("Book ID must be greater than zero.");
            }
            bool exists = books.Any(b => b.Id == book.Id);

                if (exists)
                {
                    Console.WriteLine("Book already exists!");
                    return;
                }
                books.Add(book);
                Console.WriteLine("Book added successfully!");
            }
        /// <summary>
        /// Displays all books currently stored in the library.
        /// </summary>
        public void DisplayBooks()
            {
                foreach (Book book in books)
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine("--------------------");
                }
            }
        /// <summary>
        /// Searches for a book using its unique identifier.
        /// </summary>
        /// <param name="id">The ID of the book to search for.</param>
        /// <returns>The book if found; otherwise, null.</returns>
        public Book? SearchBook(int id)
            {
                return books.FirstOrDefault(b => b.Id == id);
            }
        /// <summary>
        /// Removes a book from the library using its ID.
        /// </summary>
        /// <param name="id">The ID of the book to remove.</param>
        public void RemoveBook(int id)
            {
                Book? book = SearchBook(id);

                if (book == null)
                {
                    Console.WriteLine("Book not found!");
                    return;
                }

                books.Remove(book);
                Console.WriteLine("Book removed successfully!");
            }
        /// <summary>
        /// Borrows a book for a specified library member.
        /// </summary>
        /// <param name="id">The ID of the book to borrow.</param>
        /// <param name="member">The member who wants to borrow the book.</param>
        /// <exception cref="BookNotFoundException">
        /// Thrown when the requested book does not exist.
        /// </exception>
        public void BorrowBook(int id,Member member)
        {
            Book? book = SearchBook(id);

            if (book == null)
            {
                throw new BookNotFoundException("The requested book was not found!");
            }

            if (book.IsAvailable)
            {
                book.Borrow(member);
                OnBookBorrowed?.Invoke(book.Title, member.Name);
            }
            else
            {
                book.Borrow(member);
            }
        }
        /// <summary>
        /// Returns a borrowed book to the library.
        /// </summary>
        /// <param name="id">The ID of the book to return.</param>
        public void ReturnBook(int id)
        {
            Book? book = SearchBook(id);

            if (book == null)
            {
                Console.WriteLine("Book not found!");
                return;
            }

            book.ReturnBook();
        }

    }
    }


