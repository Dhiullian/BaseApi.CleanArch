using System;

namespace CleanArch.BaseApi.Application.Feature.ViewModels.Categories
{
    public class CreateCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
