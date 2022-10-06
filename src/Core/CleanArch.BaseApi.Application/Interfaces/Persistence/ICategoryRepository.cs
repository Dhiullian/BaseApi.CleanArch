using CleanArch.BaseApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.BaseApi.Application.Interfaces.Persistence
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
