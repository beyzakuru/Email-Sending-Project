using CoreLayer.Models;
using CoreLayer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class MailAccountRepository : GenericRepository<MailAccount>, IMailAccountRepository
    {
        public MailAccountRepository(AppDbContext context) : base(context)
        {
        }
    }
}
