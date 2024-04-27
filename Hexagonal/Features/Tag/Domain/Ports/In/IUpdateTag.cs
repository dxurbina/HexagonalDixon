using Hexagonal.Features.Tag.Domain.Models;

namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public interface IUpdateTag
    {
        Task<TagModel> Update(int id, TagModel tag);

    }
}
