using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Repository
{
    public class UserRepository : Repository<UserMaster>, IUserRepository
    {
        public UserRepository(DbContext context)
            : base(context)
        {

        }
        public UserMaster GetById(int id)
        {
            return FindBy(x => x.Userid == id).FirstOrDefault();
        }

    }
}
