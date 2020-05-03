using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace extendable_generic_repo.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int Commit();
    }
}
