using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DTOs
{
    public class MailAccountDto
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string MailServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string MailType { get; set; }
    }
}
