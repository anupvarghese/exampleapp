using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Repository
{
    public class ScanDetailRepository : Repository<IBOBTran>, IScanDetailRepository
    {
        public ScanDetailRepository(DbContext context)
            : base(context)
        {

        }
        public IBOBTran GetById(int id)
        {
            return FindBy(x => x.TransactionId == id).FirstOrDefault();
        }
    }
    
}
