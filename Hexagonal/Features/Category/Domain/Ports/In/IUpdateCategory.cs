using Hexagonal.Features.Category.Domain.Models;

namespace Hexagonal.Features.Category.Domain.Ports.In
{
    public interface IUpdateCategory
    {
        Task<CategoryModel> Update(int id, CategoryModel category);

    }
}
