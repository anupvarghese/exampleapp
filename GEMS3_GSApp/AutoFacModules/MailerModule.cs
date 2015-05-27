using Autofac;
using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace GEMS3_GSApp.AutoFacModules
{
    public class MailerModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(EmailService)).As(typeof(IEmailService)).InstancePerRequest();
        }
    }
}