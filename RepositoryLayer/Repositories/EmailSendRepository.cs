using CoreLayer.Models;
using CoreLayer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class EmailSendRepository : GenericRepository<EmailSend>, IEmailSendRepository
    {
        public EmailSendRepository(AppDbContext context) : base(context)
        {
        }
    }
}
