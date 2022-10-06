using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;
using MediatR;
using System.Collections.Generic;

namespace CleanArch.BaseApi.Application.Feature.Query.Categories
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
