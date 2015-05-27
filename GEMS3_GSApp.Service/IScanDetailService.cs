using GEMS3_GSApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Service
{
    public interface IScanDetailService : IEntityService<IBOBTran>
    {
        IBOBTran GetById(int id);
    }
}
