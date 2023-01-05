using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using CleanArch.BaseApi.Application.Interfaces.Infrastructure;
using CsvHelper;

namespace CleanArch.BaseApi.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
