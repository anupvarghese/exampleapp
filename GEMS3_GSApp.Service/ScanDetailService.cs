using GEMS3_GSApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Service
{
    public class ScanDetailService: EntityService<IBOBTran>, IScanDetailService
    {
        IUnitOfWork _unitOfWork;
        IScanDetailRepository _scanDetailRepo;

        public ScanDetailService(IUnitOfWork unitOfWork, IScanDetailRepository scanDetailRepo)
            : base(unitOfWork, scanDetailRepo)
        {
            _unitOfWork = unitOfWork;
            _scanDetailRepo = scanDetailRepo;
        }

        public IBOBTran GetById(int Id)
        {
            return _scanDetailRepo.GetById(Id);
        }
    }
}
