using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Domain.Ports.In;
using Hexagonal.Features.Tag.Domain.Ports.Out;

namespace Hexagonal.Features.Tag.Application.UseCases
{
    public class UpdateTagImpl : IUpdateTag
    {
        private readonly ITagDbAdapterPort _adapter;

        public UpdateTagImpl(ITagDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<TagModel> Update(int id, TagModel tag)
        {
            return _adapter.Update(id, tag);
        }

    }
}
