using CleanArch.BaseApi.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CleanArch.BaseApi.Application.Interfaces.Persistence
{
    public interface IEventRepository : IBaseRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string eventName, DateTime date);
    }
}
