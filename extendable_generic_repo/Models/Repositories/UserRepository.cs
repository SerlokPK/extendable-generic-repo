using extendable_generic_repo.Models.DbModels;
using extendable_generic_repo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace extendable_generic_repo.Models.Repositories
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        public UserRepository(TestContext context) : base(context)
        {

        }

        // We can also override default method, like here, to include something
        public override IEnumerable<User> GetAll()
        {
            return _entities.Set<User>().Include(x => x.Country).AsEnumerable();
        }
        public User GetById(int id)
        {
            return _dbset.Include(x => x.Country).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
