using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;
using MediatR;
using System.Collections.Generic;

namespace CleanArch.BaseApi.Application.Feature.Query.Categories
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
