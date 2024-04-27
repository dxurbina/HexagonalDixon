using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Domain.Ports.Out;

namespace Hexagonal.Features.Category.Domain.Ports.In
{
    public class GetCategoriesImpl : IGetCategories
    {
        private readonly ICategoryDbAdapterPort _adapter;

        public GetCategoriesImpl(ICategoryDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<List<CategoryModel>> GetCategories()
        {
            return _adapter.FindAll();
        }
    }

}
