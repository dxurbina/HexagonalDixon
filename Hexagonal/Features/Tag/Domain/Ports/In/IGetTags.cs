using Hexagonal.Features.Tag.Domain.Models;

namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public interface IGetTags
    {
        Task<List<TagModel>> GetTags();
    }
}