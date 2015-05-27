using GEMS3_GSApp.KendoUiModels;
using GEMS3_GSApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace GEMS3_GSApp.Controllers
{
    public class ScanDetailsController : ODataController
    {
        private readonly IUserService _userService;
        private readonly IScanDetailService _scanDetailService;

        public ScanDetailsController(IUserService userService, IScanDetailService scanDetailService)
        {
            _userService = userService;
            _scanDetailService = scanDetailService;
        }

        // GET api/<controller>
        [EnableQuery]
        public IQueryable<ScanDetail> Get()
        {
            var ibobTrans = _scanDetailService.GetAll();
            var userDetail = _userService.GetAll();

            var scanDetail = (from n in ibobTrans
                              join m in userDetail on
                              n.UserId equals m.Userid
                              select new ScanDetail
                              {
                                  ITRNumber = n.ITRNumber,
                                  ITRSku = n.itrBinType,
                                  ScannedSku = n.IbcType,
                                  UserName = m.Username,
                                  OneDBarcode = n.Barcode,
                                  EventType = n.EventType,
                                  DepotLoc = n.DepotLoc,
                                  ActivityDate = n.ActivityDate
                              }).AsQueryable();
            return scanDetail;
                              
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}