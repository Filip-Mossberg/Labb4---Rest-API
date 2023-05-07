using APILibrary.Models;
using Labb4___Rest_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4___Rest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private ILinkRepo _linkRepository;
        public LinkController(ILinkRepo linkRepository)
        {
            this._linkRepository = linkRepository;
        }

        [HttpPost]
        public async Task<IActionResult> NewLinksAndConnect(int _PersonID, int _HobbyID, List<Link> links)
        {
            try
            {
                var newLinks = await _linkRepository.NewLink(links);

                foreach (var item in newLinks)
                {
                    PersonHobby connect = new PersonHobby
                    {
                        HobbyID = _HobbyID,
                        LinkID = item.LinkID,
                        PersonID = _PersonID
                    };

                    await _linkRepository.ConnectLink(connect);
                }

                return Content($"Added new links, and connected them to person {_PersonID} and hobby {_HobbyID}");
            }
            catch
            {
                return BadRequest("Inputs not valid!");
            }
        }

        [HttpGet("HobbyLinks/{id:int}")]
        public async Task<IActionResult> GetHobbyLinks(int id)
        {
            try
            {
                var links = await _linkRepository.HobbyLinks(id);
                if(links != Enumerable.Empty<Link>())
                {
                    return Ok(links);
                }
                return NotFound($"Hobby with ID {id} not found!");
            }
            catch
            {
                return BadRequest("Invalid ID input!");
            }
            
        }
    }
}
