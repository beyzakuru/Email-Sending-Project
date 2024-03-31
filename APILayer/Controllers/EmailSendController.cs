using AutoMapper;
using CoreLayer.DTOs;
using CoreLayer.Models;
using CoreLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSendController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmailSendService _emailSendService;

        public EmailSendController(IMapper mapper, IEmailSendService emailSendService)
        {
            _mapper = mapper;
            _emailSendService = emailSendService;
        }

        // Get api/emailsend/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var sends = await _emailSendService.GetAllAsync();
            var sendsDto = _mapper.Map<List<EmailSendDto>>(sends.ToList());
            return Ok(sendsDto);
        }

        // Get api/emailsend/3
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var send = await _emailSendService.GetById(id);
            var sendDto = _mapper.Map<EmailSendDto>(send);
            return Ok(sendDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(EmailSendDto emailSendDto)
        {
            var send = await _emailSendService.AddAsync(_mapper.Map<EmailSend>(emailSendDto));
            var sendDto = _mapper.Map<EmailSendDto>(send);
            return Ok(sendDto);
        }
    }

   
}
