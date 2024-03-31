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
    public class PersonController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPersonService _personService;

        public PersonController(IMapper mapper, IPersonService personService)
        {
            _mapper = mapper;
            _personService = personService;
        }

        // Get api/person/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var people = await _personService.GetAllAsync();
            var peopleDto = _mapper.Map<List<PersonDto>>(people.ToList());
            return Ok(peopleDto);
        }

        // Get api/person/3
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _personService.GetById(id);
            var personDto = _mapper.Map<PersonDto>(person);
            return Ok(personDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(PersonDto personDto)
        {
            var person = await _personService.AddAsync(_mapper.Map<Person>(personDto));
            var personDtos = _mapper.Map<PersonDto>(person);
            return Ok(personDtos);
        }
    }
}
