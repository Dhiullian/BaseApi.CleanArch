using AutoMapper;
using BaseApi.CleanArch.Application.UnitTests.Categories.Mocks;
using CleanArch.BaseApi.Application.Feature.Command.Categories;
using CleanArch.BaseApi.Application.Feature.CommandHanddlers.Categories;
using CleanArch.BaseApi.Application.Interfaces.Persistence;
using CleanArch.BaseApi.Application.MappingProfiles;
using CleanArch.BaseApi.Domain.Entities;
using Moq;
using Shouldly;
using Xunit;

namespace BaseApi.CleanArch.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IBaseRepository<Category>> _mockCategoryRepository;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CategoriesMap>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(5);
        }
    }
}
