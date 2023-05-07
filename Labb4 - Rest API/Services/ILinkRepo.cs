using APILibrary.Models;

namespace Labb4___Rest_API.Services
{
    public interface ILinkRepo
    {
        Task<List<Link>> NewLink(List<Link> link);
        // Basically the same method as NewPersonHobby in IPersonRepo
        Task<PersonHobby> ConnectLink(PersonHobby personHobby);
        Task<IEnumerable<Link>> HobbyLinks(int id);
    }
}
