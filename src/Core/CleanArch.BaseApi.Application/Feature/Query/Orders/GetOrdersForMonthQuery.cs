using CleanArch.BaseApi.Application.Feature.ViewModels.Orders;
using MediatR;

namespace CleanArch.BaseApi.Application.Feature.Query.Orders
{
    public class GetOrdersForMonthQuery : IRequest<PagedOrdersForMonthVm>
    {
        public DateTime Date { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
