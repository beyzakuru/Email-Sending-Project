using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class EmailSend
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public string TransmissionStatus { get; set; }

        // MailAccount ile arasında 1-N ilişkisi var. Buraya FK tanımlaması yapacaığım.

        // FK
        public int MailAccountId { get; set; }
        public MailAccount MailAccount { get; set; }


        // Person ile arasında 1-N ilişkisi var. Buraya FK tanımlaması yapacağım.

        // FK
        public int PersonId { get; set; }
        public Person Person { get; set; }


        // Report ile arasındaki 1-N ilişkisi için;
        public ICollection<Report> Reports { get; set; }


    }
}
