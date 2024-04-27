using Hexagonal.Features.Category.Domain.Ports.In;
using Hexagonal.Features.Category.Domain.Ports.Out;

namespace Hexagonal.Features.Category.Application.UseCases
{
    public class DeleteCategoryImpl : IDeleteCategory
    {
        private readonly ICategoryDbAdapterPort _adapter;

        public DeleteCategoryImpl(ICategoryDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<int> Delete(int id)
        {
            return _adapter.Delete(id);
        }

    }
}
