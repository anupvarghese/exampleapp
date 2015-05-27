using GEMS3_GSApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Service
{
    public interface IUserService : IEntityService<UserMaster>
    {
        UserMaster GetById(int id);
    }
}
