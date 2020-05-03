using extendable_generic_repo.Models.DbModels;

namespace extendable_generic_repo.Models.Interfaces
{
    public interface ICountryService : IEntityService<Country>
    {
        Country GetById(int Id);
    }
}
