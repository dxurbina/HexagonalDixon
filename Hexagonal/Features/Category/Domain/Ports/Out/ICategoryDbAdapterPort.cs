using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Shared.Domain.Ports.Out;

namespace Hexagonal.Features.Category.Domain.Ports.Out
{
    public interface ICategoryDbAdapterPort : IDbCrudAdapter<CategoryModel>
    {
    }
}
