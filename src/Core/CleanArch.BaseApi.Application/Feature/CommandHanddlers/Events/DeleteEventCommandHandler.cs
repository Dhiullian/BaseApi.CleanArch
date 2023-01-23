using AutoMapper;
using CleanArch.BaseApi.Application.Feature.Command.Event;
using CleanArch.BaseApi.Application.Interfaces.Persistence;
using CleanArch.BaseApi.Domain.Entities;
using MediatR;

namespace CleanArch.BaseApi.Application.Feature.CommandHanddlers.Events
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IBaseRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IMapper mapper, IBaseRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.EventId);

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
