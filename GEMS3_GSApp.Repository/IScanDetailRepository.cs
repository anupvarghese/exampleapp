using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Repository
{
    public interface IScanDetailRepository : IRepository<IBOBTran>
    {
        IBOBTran GetById(int id);
    }
}
