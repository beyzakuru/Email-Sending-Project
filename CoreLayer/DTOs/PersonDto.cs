using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DatOfBirth { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Title { get; set; }
        public string Workplace { get; set; }
    }
}
