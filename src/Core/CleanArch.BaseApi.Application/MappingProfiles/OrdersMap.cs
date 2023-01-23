using AutoMapper;
using CleanArch.BaseApi.Application.Feature.ViewModels.Orders;
using CleanArch.BaseApi.Domain.Entities;

namespace CleanArch.BaseApi.Application.MappingProfiles
{
    public class OrdersMap : Profile
    {
        public OrdersMap()
        {
            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
