using AutoMapper;
using CleanArch.BaseApi.Application.Feature.Command.Event;
using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;
using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using CleanArch.BaseApi.Domain.Entities;

namespace CleanArch.BaseApi.Application.MappingProfiles
{
    public class EventsMap : Profile
    {
        public EventsMap()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
        }
    }
}
