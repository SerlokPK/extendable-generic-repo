using extendable_generic_repo.Models.DbModels;

namespace extendable_generic_repo.Models.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetById(int id);
    }
}
