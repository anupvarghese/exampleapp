using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEMS3_GSApp.KendoUiModels
{
    public class ScanDetail
    {
        public string ITRNumber { get; set; }
        public string EventType { get; set; }
        public string OneDBarcode { get; set; }
        public DateTime ActivityDate { get; set; }
        public string DepotLoc { get; set; }
        public string ScannedSku { get; set; }
        public string ITRSku { get; set; }
        public string UserName { get; set; }
    }
}