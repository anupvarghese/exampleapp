using GEMS3_GSApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Service
{
    public class UserService : EntityService<UserMaster>, IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _userRepo;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepo)
            : base(unitOfWork, userRepo)
        {
            _unitOfWork = unitOfWork;
            _userRepo = userRepo;
        }

        public UserMaster GetById(int Id)
        {
            return _userRepo.GetById(Id);
        }
    }
}
