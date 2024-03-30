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
    public class EmailSendService : Service<EmailSend>, IEmailSendService
    {
        public EmailSendService(IGenericRepository<EmailSend> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
