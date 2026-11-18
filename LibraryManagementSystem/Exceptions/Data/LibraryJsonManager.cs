using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using System.IO;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.Data
{
    /// <summary>
    /// Manages saving and loading library books using JSON serialization.
    /// </summary>
    public class LibraryJsonManager
    {
        /// <summary>
        /// Saves the list of books to a JSON file.
        /// </summary>
        /// <param name="books">The list of books to be saved.</param>
        public void SaveBooks(List<Book> books)
        {
            string json = JsonSerializer.Serialize(books);
            File.WriteAllText("books.json", json);
        }
        /// <summary>
        /// Asynchronously saves the list of books to a JSON file.
        /// </summary>
        /// <param name="books">The list of books to be saved.</param>
        public async Task SaveBooksAsync(List<Book> books)
        {
            string json = JsonSerializer.Serialize(books);

            await File.WriteAllTextAsync("books.json", json);
        }
        /// <summary>
        /// Loads the list of books from a JSON file.
        /// </summary>
        /// <returns>A list of books loaded from the file, or an empty list if the file does not exist.</returns>
        public List<Book> LoadBooks()
        {
            if (!File.Exists("books.json"))
            {
                return new List<Book>();
            }

            string json = File.ReadAllText("books.json");

            return JsonSerializer.Deserialize<List<Book>>(json)
                   ?? new List<Book>();
        }
        /// <summary>
        /// Asynchronously loads the list of books from a JSON file.
        /// </summary>
        /// <returns>A list of books loaded from the file, or an empty list if the file does not exist.</returns>
        public async Task<List<Book>> LoadBooksAsync()
        {
            if (!File.Exists("books.json"))
            {
                return new List<Book>();
            }

            string json = await File.ReadAllTextAsync("books.json");

            return JsonSerializer.Deserialize<List<Book>>(json)
                   ?? new List<Book>();
        }

    }
}
