using Hexagonal.Features.Category.Domain.Models;

namespace Hexagonal.Features.Category.Domain.Ports.In
{
    public interface IGetCategories
    {
        Task<List<CategoryModel>> GetCategories();
    }
}