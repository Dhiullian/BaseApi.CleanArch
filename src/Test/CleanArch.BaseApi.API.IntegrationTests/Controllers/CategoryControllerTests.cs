using CleanArch.BaseApi.API.IntegrationTests.Base;
using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;
using Newtonsoft.Json;
using Xunit;

namespace CleanArch.BaseApi.API.IntegrationTests.Controllers
{
    public class CategoryControllerTests : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory = new CustomWebApplicationFactory();

        public CategoryControllerTests()
        {           
        }

        [Fact]
        public async Task ReturnsSuccessResult()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/category");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<CategoryListVm>>(responseString);

            Assert.IsType<List<CategoryListVm>>(result);
            Assert.NotEmpty(result);
        }
    }
}
