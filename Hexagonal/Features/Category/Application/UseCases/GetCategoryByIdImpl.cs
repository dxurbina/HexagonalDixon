using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Domain.Ports.In;
using Hexagonal.Features.Category.Domain.Ports.Out;

namespace Hexagonal.Features.Category.Application.UseCases
{
    public class GetCategoryByIdImpl : IGetCategoryById
    {
        private readonly ICategoryDbAdapterPort _adapter;

        public GetCategoryByIdImpl(ICategoryDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<CategoryModel> GetCategoryById(int id)
        {
            return _adapter.FindById(id);
        }
    }
}
