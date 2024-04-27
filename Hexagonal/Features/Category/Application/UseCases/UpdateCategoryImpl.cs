using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Domain.Ports.In;
using Hexagonal.Features.Category.Domain.Ports.Out;

namespace Hexagonal.Features.Category.Application.UseCases
{
    public class UpdateCategoryImpl : IUpdateCategory
    {
        private readonly ICategoryDbAdapterPort _adapter;

        public UpdateCategoryImpl(ICategoryDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<CategoryModel> Update(int id, CategoryModel category)
        {
            return _adapter.Update(id, category);
        }

    }
}
