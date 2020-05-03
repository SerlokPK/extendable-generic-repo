using extendable_generic_repo.Models.DbModels;
using extendable_generic_repo.Models.Interfaces;
using System.Linq;

namespace extendable_generic_repo.Models.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(TestContext context) : base(context)
        {

        }
        public Country GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}
