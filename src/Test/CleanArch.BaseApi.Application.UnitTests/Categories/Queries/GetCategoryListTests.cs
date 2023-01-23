using AutoMapper;
using BaseApi.CleanArch.Application.UnitTests.Categories.Mocks;
using CleanArch.BaseApi.Application.Feature.Query.Categories;
using CleanArch.BaseApi.Application.Feature.QueryHanddlers.Categories;
using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;
using CleanArch.BaseApi.Application.Interfaces.Persistence;
using CleanArch.BaseApi.Application.MappingProfiles;
using CleanArch.BaseApi.Domain.Entities;
using Moq;
using Shouldly;
using Xunit;

namespace BaseApi.CleanArch.Application.UnitTests.Categories.Queries
{
    public class GetCategoryListTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IBaseRepository<Category>> _mockCategoryRepository;

        public GetCategoryListTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CategoriesMap>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
