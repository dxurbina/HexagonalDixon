using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Domain.Ports.Out;

namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public class GetTagsImpl : IGetTags
    {
        private readonly ITagDbAdapterPort _adapter;

        public GetTagsImpl(ITagDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<List<TagModel>> GetTags()
        {
            return _adapter.FindAll();
        }
    }

}
