using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using MediatR;

namespace CleanArch.BaseApi.Application.Feature.Query.Events
{
    public class GetEventsExportQuery : IRequest<EventExportFileVm>
    {
    }
}
