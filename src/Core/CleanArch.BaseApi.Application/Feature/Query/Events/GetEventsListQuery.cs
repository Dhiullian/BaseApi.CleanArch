using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using MediatR;
using System.Collections.Generic;

namespace CleanArch.BaseApi.Application.Feature.Query.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
