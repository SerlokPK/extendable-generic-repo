
using extendable_generic_repo.Models.DbModels;

namespace extendable_generic_repo.Models.Interfaces
{
    public interface IUserService : IEntityService<User>
    {
        User GetById(int Id);
    }
}
