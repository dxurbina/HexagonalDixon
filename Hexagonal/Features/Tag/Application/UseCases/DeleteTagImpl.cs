using Hexagonal.Features.Tag.Domain.Ports.In;
using Hexagonal.Features.Tag.Domain.Ports.Out;

namespace Hexagonal.Features.Tag.Application.UseCases
{
    public class DeleteTagImpl : IDeleteTag
    {
        private readonly ITagDbAdapterPort _adapter;

        public DeleteTagImpl(ITagDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<int> Delete(int id)
        {
            return _adapter.Delete(id);
        }

    }
}
