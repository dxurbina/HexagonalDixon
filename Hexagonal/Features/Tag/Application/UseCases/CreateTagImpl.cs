using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Domain.Ports.In;
using Hexagonal.Features.Tag.Domain.Ports.Out;

namespace Hexagonal.Features.Tag.Application.UseCases
{
    public class CreateTagImpl : ICreateTag
    {
        private readonly ITagDbAdapterPort _adapter;

        public CreateTagImpl(ITagDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<TagModel> Create(TagModel tag)
        {
            return _adapter.Create(tag);
        }

    }
}
