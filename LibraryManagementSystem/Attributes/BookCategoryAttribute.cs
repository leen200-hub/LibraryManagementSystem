using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    /// <summary>
    /// Specifies the category of a book.
    /// </summary>
    public class BookCategoryAttribute : Attribute
    {
        /// <summary>
        /// Gets the category assigned to the book.
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// Initializes a new instance of the BookCategoryAttribute class.
        /// </summary>
        /// <param name="category">The category assigned to the book.</param>
        public BookCategoryAttribute(string category)
            {
                Category = category;
            }
        }
    }
