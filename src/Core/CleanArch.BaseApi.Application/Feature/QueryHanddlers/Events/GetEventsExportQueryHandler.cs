using AutoMapper;
using CleanArch.BaseApi.Application.Feature.Query.Events;
using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using CleanArch.BaseApi.Application.Interfaces.Infrastructure;
using CleanArch.BaseApi.Application.Interfaces.Persistence;
using MediatR;

namespace CleanArch.BaseApi.Application.Feature.QueryHanddlers.Events
{
    public class GetEventsExportQueryHandler : IRequestHandler<GetEventsExportQuery, EventExportFileVm>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetEventsExportQueryHandler(IMapper mapper, IEventRepository eventRepository, ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _csvExporter = csvExporter;
        }

        public async Task<EventExportFileVm> Handle(GetEventsExportQuery request, CancellationToken cancellationToken)
        {
            var allEvents = _mapper.Map<List<EventExportDto>>((await _eventRepository.ListAllAsync()).OrderBy(x => x.Date));

            var fileData = _csvExporter.ExportEventsToCsv(allEvents);

            var eventExportFileDto = new EventExportFileVm() { ContentType = "text/csv", Data = fileData, EventExportFileName = $"Events_{DateTime.Now}.csv" };

            return eventExportFileDto;
        }
    }
}
