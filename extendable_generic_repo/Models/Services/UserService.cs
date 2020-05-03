using extendable_generic_repo.Models.DbModels;
using extendable_generic_repo.Models.Interfaces;

namespace extendable_generic_repo.Models.Services
{
    public class UserService : EntityService<User>, IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _personRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository personRepository)
            : base(unitOfWork, personRepository)
        {
            _unitOfWork = unitOfWork;
            _personRepository = personRepository;
        }

        public User GetById(int Id)
        {
            return _personRepository.GetById(Id);
        }
    }
}
