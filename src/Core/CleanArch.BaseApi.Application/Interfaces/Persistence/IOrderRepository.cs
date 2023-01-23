using CleanArch.BaseApi.Domain.Entities;

namespace CleanArch.BaseApi.Application.Interfaces.Persistence
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size);
        Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
    }
}
