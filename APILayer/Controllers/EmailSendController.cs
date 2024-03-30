using AutoMapper;
using CoreLayer.DTOs;
using CoreLayer.Models;
using CoreLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Mapping;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSendController : ControllerBase
    {
        private readonly IEmailSendService _emailSendService;
        private readonly IMapper _mapper;

        public EmailSendController(IEmailSendService emailSendService, IMapper mapper )
        {
            _emailSendService = emailSendService;
            _mapper = mapper;
        }

        //IActionResult controller tarafındaki geriye dönüş değeri oluyor.
        // api/EmailSend
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var sends =await _emailSendService.GetAllAsync();
            var sendDto = _mapper.Map<EmailSendDto>(sends);
            return Ok(sendDto);
        }

        //burada kalmıştım.
        [HttpPost]
        public async Task<IActionResult> Save(EmailSend emailSend)
        {
            var send = await _emailSendService.AddAsync(emailSend);
            return Ok(send);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var send = await _emailSendService.GetById(id);
            return Ok(send);
        }

    }
}
