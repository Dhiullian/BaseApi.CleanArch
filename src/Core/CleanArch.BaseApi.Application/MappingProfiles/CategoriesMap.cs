using AutoMapper;
using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;
using CleanArch.BaseApi.Application.Feature.ViewModels.Events;
using CleanArch.BaseApi.Domain.Entities;

namespace CleanArch.BaseApi.Application.MappingProfiles
{
    public class CategoriesMap : Profile
    {
        public CategoriesMap()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
