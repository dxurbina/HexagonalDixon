using Hexagonal.Features.Category.Domain.Models;

namespace Hexagonal.Features.Category.Domain.Ports.In
{
    public interface IGetCategoryById
    {
        Task<CategoryModel?> GetCategoryById(int id);
    }
}
