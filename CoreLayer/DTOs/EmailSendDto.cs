using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DTOs
{
    public class EmailSendDto
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string content { get; set; }
        public int MailAccountId { get; set; }
        public int PersonId { get; set; }
    }
}
