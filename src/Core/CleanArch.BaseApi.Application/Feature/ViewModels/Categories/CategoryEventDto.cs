using System;

namespace CleanArch.BaseApi.Application.Feature.ViewModels.Categories
{
    public class CategoryEventDto
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
    }
}
