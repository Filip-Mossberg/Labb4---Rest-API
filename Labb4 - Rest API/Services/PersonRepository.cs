using APILibrary.Models;
using Labb4___Rest_API.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace Labb4___Rest_API.Services
{
    public class PersonRepository : IPersonRepo
    {
        private AppDbContext _appDbContext;
        public PersonRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            return await _appDbContext.Person.ToListAsync();
        }

        public async Task<IQueryable<Hobby>> Hobbies(int id)
        {
            // We can return an Iqueriable without specifying <Hobby> also
            IQueryable<Hobby> hobbies = await Task.Run(() => from ph in _appDbContext.PersonHobby
                              join h in _appDbContext.Hobby on ph.HobbyID equals h.HobbyID
                              join p in _appDbContext.Person on ph.PersonID equals p.PersonID
                              where ph.PersonID == id
                              select h);

            return hobbies;
        }

        public async Task<PersonHobby> NewPersonHobby(PersonHobby newConnection)
        {
            var test = await _appDbContext.PersonHobby.AddAsync(newConnection);
            await _appDbContext.SaveChangesAsync();
            return test.Entity;
        }

        public async Task<List<string>> PersonLinks(int id)
        {
            var links = await (from hobbyperson in _appDbContext.PersonHobby
                             join link in _appDbContext.Link on
                             hobbyperson.LinkID equals link.LinkID
                             where hobbyperson.PersonID == id
                             select link.URL).ToListAsync();

            return links;
        }
    }
}
