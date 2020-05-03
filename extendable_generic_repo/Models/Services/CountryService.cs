using extendable_generic_repo.Models.DbModels;
using extendable_generic_repo.Models.Interfaces;

namespace extendable_generic_repo.Models.Services
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork _unitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }


        public Country GetById(int Id)
        {
            return _countryRepository.GetById(Id);
        }
    }
}
