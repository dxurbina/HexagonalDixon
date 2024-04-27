using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Domain.Ports.In;
using Hexagonal.Features.Category.Domain.Ports.Out;

namespace Hexagonal.Features.Category.Application.UseCases
{
    public class CreateCategoryImpl : ICreateCategory
    {
        private readonly ICategoryDbAdapterPort _adapter;

        public CreateCategoryImpl(ICategoryDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<CategoryModel> Create(CategoryModel category)
        {
            return _adapter.Create(category);
        }

    }
}
