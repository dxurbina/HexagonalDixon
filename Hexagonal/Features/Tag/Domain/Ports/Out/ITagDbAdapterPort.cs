using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Shared.Domain.Ports.Out;

namespace Hexagonal.Features.Tag.Domain.Ports.Out
{
    public interface ITagDbAdapterPort : IDbCrudAdapter<TagModel>
    {
    }
}
