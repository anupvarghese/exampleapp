using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEMS3_GSApp.EmailModels
{
    public class NewTaskEmailCommand
    {
        public string EmailAddress { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public string Title { get; set; }
    }
}