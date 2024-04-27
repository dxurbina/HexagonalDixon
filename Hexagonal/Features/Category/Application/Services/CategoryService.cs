using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Domain.Ports.In;

namespace Hexagonal.Features.Category.Application.Services
{
    public class CategoryService: ICategoryServicePort
    {
        private readonly IGetCategoryById _getCategoryByIdService;
        private readonly IGetCategories _getCategoriesService;
        private readonly ICreateCategory _createCategory;
        private readonly IUpdateCategory _updateCategory;
        private readonly IDeleteCategory _deleteCategory;


        public CategoryService(IGetCategoryById getCategoryByIdService, IGetCategories getCategoriesService, ICreateCategory createCategory, IUpdateCategory updateCategory, IDeleteCategory deleteCategory)
        {
            _getCategoryByIdService = getCategoryByIdService;
            _getCategoriesService = getCategoriesService;
            _createCategory = createCategory;
            _updateCategory = updateCategory;
            _deleteCategory = deleteCategory;
        }

        public Task<List<CategoryModel>> GetCategories()
        {
            return _getCategoriesService.GetCategories();
        }

        public Task<CategoryModel?> GetCategoryById(int id)
        {
            return _getCategoryByIdService.GetCategoryById(id);
        }

        public Task<CategoryModel> Create(CategoryModel category)
        {
            return _createCategory.Create(category);
        }

        public Task<CategoryModel> Update(int id, CategoryModel category)
        {
            return _updateCategory.Update(id, category);
        }

        public Task<int> Delete(int id)
        {
            return _deleteCategory.Delete(id);
        }


    }
}
