using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DatOfBirth { get; set; }
        public string HomePhone { get; set;}
        public string CellPhone { get; set;}
        public string Title { get; set;}
        public string Workplace { get; set; }

        // EmailSend ile arasındaki 1-N ilişkisi için;
        public ICollection<EmailSend> EmailSends { get; set; }

    }
}
