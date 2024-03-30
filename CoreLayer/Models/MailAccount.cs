using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class MailAccount
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string MailServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string MailType { get; set; }

        // EmailSend ile arasındaki 1-N ilişkisi için;
        public ICollection<EmailSend> EmailSends { get; set; }
    }
}
