using extendable_generic_repo.Models.DbModels;

namespace extendable_generic_repo.Models.Interfaces
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(int id);
    }
}
