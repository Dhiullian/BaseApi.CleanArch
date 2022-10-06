using MediatR;
using System;

namespace CleanArch.BaseApi.Application.Feature.Command.Event
{
    public class DeleteEventCommand : IRequest
    {
        public Guid EventId { get; set; }
    }
}
