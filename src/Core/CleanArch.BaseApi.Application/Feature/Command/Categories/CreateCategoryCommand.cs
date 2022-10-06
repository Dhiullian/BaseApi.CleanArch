using CleanArch.BaseApi.Application.Feature.Response.Categories;
using MediatR;

namespace CleanArch.BaseApi.Application.Feature.Command.Categories
{
    public class CreateCategoryCommand : IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; }
    }
}
