using CoreLayer.Models;
using CoreLayer.Repostories;
using CoreLayer.Services;
using CoreLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class MailAccountService : Service<MailAccount>, IMailAccountService
    {
        public MailAccountService(IGenericRepository<MailAccount> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
