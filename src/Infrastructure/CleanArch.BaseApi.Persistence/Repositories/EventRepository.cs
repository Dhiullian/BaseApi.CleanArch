using CleanArch.BaseApi.Application.Interfaces.Persistence;
using CleanArch.BaseApi.Domain.Entities;
using CleanArch.BaseApi.Persistence.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.BaseApi.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(BaseApiDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
