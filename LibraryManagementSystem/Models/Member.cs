using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    /// <summary>
    /// Represents a library member who can borrow books.
    /// </summary>
    public class Member : Person 
    {
        /// <summary>
        /// Gets or sets the date when the member joined the library.
        /// </summary>
        public DateTime MembershipDate { get; set; }
        /// <summary>
        /// Initializes a new instance of the Member class.
        /// </summary>
        /// <param name="id">The unique identifier of the member.</param>
        /// <param name="name">The name of the member.</param>
        /// <param name="email">The email address of the member.</param>
        /// <param name="membershipDate">The date when the member joined the library.</param>
        public Member(int id, string name, string email,DateTime membershipDate)
            : base(id, name, email)
        {
            MembershipDate = membershipDate;
        }
        /// <summary>
        /// Gets the role of the person.
        /// </summary>
        /// <returns>The role "Member".</returns>
        public override string GetRole()
        {
            return "Member";
        }
    }
}
