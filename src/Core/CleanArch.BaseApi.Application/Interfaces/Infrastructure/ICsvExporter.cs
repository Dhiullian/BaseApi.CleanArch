using CleanArch.BaseApi.Application.Feature.ViewModels.Events;

namespace CleanArch.BaseApi.Application.Interfaces.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
