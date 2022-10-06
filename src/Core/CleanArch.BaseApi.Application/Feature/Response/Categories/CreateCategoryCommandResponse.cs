using CleanArch.BaseApi.Application.Feature.ViewModels.Categories;

namespace CleanArch.BaseApi.Application.Feature.Response.Categories
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {

        }

        public CreateCategoryDto Category { get; set; }
    }
}
