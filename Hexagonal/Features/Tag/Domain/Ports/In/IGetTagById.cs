using Hexagonal.Features.Tag.Domain.Models;

namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public interface IGetTagById
    {
        Task<TagModel?> GetTagById(int id);
    }
}
