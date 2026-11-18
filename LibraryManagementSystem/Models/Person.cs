using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Represents an abstract person in the library system.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the unique identifier of the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the email address of the person.
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        /// <param name="id">The unique identifier of the person.</param>
        /// <param name="name">The name of the person.</param>
        /// <param name="email">The email address of the person.</param>
        public Person(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        /// <summary>
        /// Gets the role of the person in the library system.
        /// </summary>
        /// <returns>The role of the person.</returns>
        public abstract string GetRole();



    }

}