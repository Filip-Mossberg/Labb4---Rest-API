using APILibrary.Models;

namespace Labb4___Rest_API.Services
{
    public interface IPersonRepo 
    {
        Task<IEnumerable<Person>> GetAllPersons();
        Task<IQueryable<Hobby>> Hobbies(int id);
        Task<List<string>> PersonLinks(int id);
        Task<PersonHobby> NewPersonHobby(PersonHobby newConnection);
    }
}
