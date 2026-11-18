// See https://aka.ms/new-console-template for more information
using LibraryManagementSystem.Attributes;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Exceptions;
using LibraryManagementSystem.Exceptions;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.Repositories;
using System.Reflection;
using LibraryManagementSystem.Attributes;
using static System.Reflection.Metadata.BlobBuilder;

Book book1 = new Book(
    1,
    "Clean Code",
    "Robert C. Martin",
    "9780132350884"
);
Member member1 = new Member(
    1,
    "Leen",
    "leen@example.com",
    DateTime.Now
);
Console.WriteLine($"Title: {book1.Title}");
Console.WriteLine($"Author: {book1.Author}");
Console.WriteLine($"Available: {book1.IsAvailable}");

book1.Borrow(member1);

Console.WriteLine($"Available: {book1.IsAvailable}");

book1.ReturnBook();

Console.WriteLine($"Available: {book1.IsAvailable}");


Console.WriteLine($"Member Name: {member1.Name}");
Console.WriteLine($"Member Email: {member1.Email}");
Console.WriteLine($"Membership Date: {member1.MembershipDate}");
Librarian librarian1 = new Librarian(
    2,
    "Ahmad",
    "ahmad@library.com",
    "EMP-001"
);

Console.WriteLine($"Librarian Name: {librarian1.Name}");
Console.WriteLine($"Librarian Email: {librarian1.Email}");
Console.WriteLine($"Employee Number: {librarian1.EmployeeNumber}");
Person person1 = member1;
Person person2 = librarian1;

Console.WriteLine(person1.GetRole());
Console.WriteLine(person2.GetRole());
Library library = new Library();
library.OnBookBorrowed += (bookTitle, memberName) =>
{
    Console.WriteLine($"{memberName} borrowed {bookTitle}");
};

library.AddBook(book1);
library.AddBook(book1);


library.DisplayBooks();
Book? foundBook = library.SearchBook(1);

if (foundBook != null)
{
    Console.WriteLine($"Found: {foundBook.Title}");
}
else
{
    Console.WriteLine("Book not found!");
}
//library.RemoveBook(1);
library.BorrowBook(1, member1);

Console.WriteLine($"Borrowed By: {book1.BorrowedBy?.Name}");
library.DisplayBooks();
library.RemoveBook(99);
library.BorrowBook(1,member1);
library.BorrowBook(1,member1);
library.ReturnBook(1);
Console.WriteLine($"Borrowed By: {book1.BorrowedBy?.Name ?? "No one"}");
library.BorrowBook(1,member1);
GenericRepository<Book> bookRepository = new GenericRepository<Book>();
bookRepository.Add(book1);
foreach (Book book in bookRepository.GetAll())
{
    Console.WriteLine($"Repository Book: {book.Title}");
}
GenericRepository<Member> memberRepository = new GenericRepository<Member>();

memberRepository.Add(member1);

foreach (Member member in memberRepository.GetAll())
{
    Console.WriteLine($"Repository Member: {member.Name}");
}
try
{
    int number = int.Parse("Hello");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
try
{
    Book invalidBook = new Book(0, "Test Book", "Unknown", "123");
    library.AddBook(invalidBook);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Library Error: {ex.Message}");
}
try
{
    library.BorrowBook(99, member1);
}
catch (BookNotFoundException ex)
{
    Console.WriteLine($"Library Exception: {ex.Message}");
}
LibraryJsonManager jsonManager = new LibraryJsonManager();
await jsonManager.SaveBooksAsync(new List<Book> { book1 });
Console.WriteLine("Books saved successfully!");
List<Book> loadedBooks = await jsonManager.LoadBooksAsync();

foreach (Book book in loadedBooks)
{
    Console.WriteLine($"Loaded Book: {book.Title}");
    Console.WriteLine($"Available: {book.IsAvailable}");
    Console.WriteLine($"Borrowed By: {book.BorrowedBy?.Name ?? "No one"}");
}
Type bookType = typeof(Book);

BookCategoryAttribute? categoryAttribute =
    bookType.GetCustomAttribute<BookCategoryAttribute>();

Console.WriteLine($"Book Category: {categoryAttribute?.Category}");
