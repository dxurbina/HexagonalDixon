using Hexagonal.Features.Tag.Domain.Models;

namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public interface ICreateTag
    {
        Task<TagModel> Create(TagModel tag);
    }

}
