using APILibrary.Models;
using Labb4___Rest_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4___Rest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonRepo _personRepository;
        public PersonController(IPersonRepo personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("AllPersons")]
        public async Task<IActionResult> GetAllPersons()
        {
            var persons = await _personRepository.GetAllPersons();
            if(persons != null)
            {
                return Ok(persons);
            }
            return BadRequest("Did not manage to get all persons");
        }

        [HttpGet("hobbies/{id:int}")]
        public async Task<IActionResult> GetPersonHobbies(int id)
        {
            var hobbies = await _personRepository.Hobbies(id);
            if(hobbies != null)
            {
                return Ok( hobbies);
            }
            return NotFound($"User with id {id} not found...");
        }

        [HttpGet("links/{id:int}")]
        public async Task<IActionResult> GetAllLinks(int id)
        {
            var links = await _personRepository.PersonLinks(id);
            if (links != null)
            {
                return Ok(links);
            }
            return NotFound($"User with id {id} not found...");
        }

        [HttpPost("NewHobby")]
        public async Task<IActionResult> NewHobbyConnection(PersonHobby newHobbyConnect)
        {
            if(newHobbyConnect != null)
            {
                var newHobby = await _personRepository.NewPersonHobby(newHobbyConnect);
                return Ok(newHobby);
            }
            return BadRequest($"Not a valid instance of the PersonHobby class!");
        }
    }
}
