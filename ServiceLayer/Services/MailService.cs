using CoreLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class MailService : IMailService
    {
        public void SendMail(string[] toAddresses, string subject, string content, string fromAddress)
        {
            throw new NotImplementedException();
        }
    }
}
