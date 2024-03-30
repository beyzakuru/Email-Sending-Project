using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Report
    {
        public int Id { get; set; }

        // EmailSend ile arasında 1-N ilişki var. FK tanımlanacak.

        // FK
        public int EmailSendId { get; set; }
        public EmailSend EmailSend { get; set; }
    }
}
