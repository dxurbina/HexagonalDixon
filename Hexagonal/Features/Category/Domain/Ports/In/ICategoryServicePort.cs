namespace Hexagonal.Features.Category.Domain.Ports.In
{
    public interface ICategoryServicePort : IGetCategories, IGetCategoryById, ICreateCategory, IUpdateCategory, IDeleteCategory
    {
    }
}
