using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Represents a librarian who manages the library.
    /// </summary>
    public class Librarian : Person
    {
        /// <summary>
        /// Gets or sets the employee number of the librarian.
        /// </summary>
        public string EmployeeNumber { get; set; } = string.Empty;
        /// <summary>
        /// Initializes a new instance of the Librarian class.
        /// </summary>
        /// <param name="id">The unique identifier of the librarian.</param>
        /// <param name="name">The name of the librarian.</param>
        /// <param name="email">The email address of the librarian.</param>
        /// <param name="employeeNumber">The employee number of the librarian.</param>
        public Librarian(int id, string name, string email, string employeeNumber)
            : base(id, name, email)
        {
            EmployeeNumber = employeeNumber;
        }
        /// <summary>
        /// Gets the role of the person.
        /// </summary>
        /// <returns>The role "Librarian".</returns>
        public override string GetRole()
        {
            return "Librarian";
        }
    }
}