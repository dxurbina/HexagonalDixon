using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Domain.Ports.In;
using Hexagonal.Features.Tag.Domain.Ports.Out;

namespace Hexagonal.Features.Tag.Application.UseCases
{
    public class GetTagByIdImpl : IGetTagById
    {
        private readonly ITagDbAdapterPort _adapter;

        public GetTagByIdImpl(ITagDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<TagModel> GetTagById(int id)
        {
            return _adapter.FindById(id);
        }
    }
}
