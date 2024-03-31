using AutoMapper;
using CoreLayer.DTOs;
using CoreLayer.Models;
using CoreLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailAccountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMailAccountService _mailAccountService;

        public MailAccountController(IMapper mapper, IMailAccountService mailAccountService)
        {
            _mapper = mapper;
            _mailAccountService = mailAccountService;
        }


        // Get api/mailaccount/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var accounts = await _mailAccountService.GetAllAsync();
            var accountsDto = _mapper.Map<List<MailAccountDto>>(accounts.ToList());
            return Ok(accountsDto);
        }

        // Get api/mailaccount/3
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var account = await _mailAccountService.GetById(id);
            var accountDto = _mapper.Map<MailAccountDto>(account);
            return Ok(accountDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(MailAccountDto mailAccountDto)
        {
            var account = await _mailAccountService.AddAsync(_mapper.Map<MailAccount>(mailAccountDto));
            var accountDto = _mapper.Map<EmailSendDto>(account);
            return Ok(accountDto);
        }
    }
}
