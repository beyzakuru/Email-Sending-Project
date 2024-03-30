using AutoMapper;
using CoreLayer.DTOs;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            // Entity'den Dto'ya çevirme
            CreateMap<EmailSend, EmailSendDto>().ReverseMap();
            CreateMap<MailAccount, MailAccountDto>().ReverseMap();
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Report, ReportDto>().ReverseMap();

            // Dto'dan entity'e çevirme
            CreateMap<EmailSendDto, EmailSend>();
            CreateMap<MailAccountDto, MailAccount>();
            CreateMap<PersonDto, Person>();
            CreateMap<ReportDto, Report>();
        }
    }
}
