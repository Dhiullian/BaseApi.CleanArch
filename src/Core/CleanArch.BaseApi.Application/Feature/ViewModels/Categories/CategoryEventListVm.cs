using System;
using System.Collections.Generic;

namespace CleanArch.BaseApi.Application.Feature.ViewModels.Categories
{
    public class CategoryEventListVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryEventDto> Events { get; set; }
    }
}
