using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models.Repositories
{
    /// <summary>
    /// Provides a generic repository for storing and managing items.
    /// </summary>
    /// <typeparam name="T">The type of items stored in the repository.</typeparam>
    
    public class GenericRepository<T>
    {
        private List<T> items = new List<T>();
        /// <summary>
        /// Adds an item to the repository.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void Add(T item)
        {
            items.Add(item);
        }
        /// <summary>
        /// Returns all items stored in the repository.
        /// </summary>
        /// <returns>A list containing all stored items.</returns>
        public List<T> GetAll()
        {
            return new List<T>(items);
        }
    }
}