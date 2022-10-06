using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using MediatR;
using System;

namespace CleanArch.BaseApi.Application.Feature.Query.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
