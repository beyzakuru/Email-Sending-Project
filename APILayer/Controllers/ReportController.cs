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
    public class ReportController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IReportService _reportService;

        public ReportController(IMapper _mapper, IReportService reportService)
        {
            _mapper = _mapper;
            _reportService = reportService;
        }

        // Get api/report/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var reports = await _reportService.GetAllAsync();
            var reportsDto = _mapper.Map<List<ReportDto>>(reports.ToList());
            return Ok(reportsDto);
        }

        // Get api/report/3
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var report = await _reportService.GetById(id);
            var reportDto = _mapper.Map<ReportDto>(report);
            return Ok(reportDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(ReportDto reportDto)
        {
            var report = await _reportService.AddAsync(_mapper.Map<Report>(reportDto));
            var reportDtos = _mapper.Map<ReportDto>(report);
            return Ok(reportDtos);
        }
    }
}
