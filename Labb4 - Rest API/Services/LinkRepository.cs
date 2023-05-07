using APILibrary.Models;
using Labb4___Rest_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4___Rest_API.Services
{
    public class LinkRepository : ILinkRepo
    {
        private AppDbContext _appDbContext;
        public LinkRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<PersonHobby> ConnectLink(PersonHobby personHobby)
        {
            var newConnection = await _appDbContext.PersonHobby.AddAsync(personHobby);
            await _appDbContext.SaveChangesAsync();
            return newConnection.Entity;
        }

        public async Task<IEnumerable<Link>> HobbyLinks(int id)
        {
            if(id <= _appDbContext.Person.Count())
            {
                var links = await (from ph in _appDbContext.PersonHobby
                                   join l in
                                   _appDbContext.Link on ph.LinkID equals l.LinkID
                                   where ph.HobbyID == id
                                   select l).ToListAsync();

                return links;
            }

            return Enumerable.Empty<Link>();
        }

        public async Task<List<Link>> NewLink(List<Link> link)
        {
            List<Link> newLinks = new List<Link>();

            foreach(var item in link)
            {
                var result = await _appDbContext.Link.AddAsync(item);
                await _appDbContext.SaveChangesAsync();
                newLinks.Add(result.Entity);
            }
            return newLinks;
        }
    }
}
