using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.Category.Domain.Ports.Out;
using Hexagonal.Shared.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Features.Category.Infrastructure
{
    public class CategoryDbAdapter: ICategoryDbAdapterPort
    {
        private readonly AppDbContext _db;

        public CategoryDbAdapter(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<CategoryModel>> FindAll()
        {
            List<CategoryModel> Categories = await _db.Categories
                .Select(x => x.ToModel())
                .ToListAsync();

            return Categories;
        }

        public async Task<CategoryModel?> FindById(int id)
        {
            CategoryEntity? categoryFound = await _db.Categories
                .FirstOrDefaultAsync(i => i.Id == id);

            var categoryModel = categoryFound?.ToModel();

            return categoryModel;
        }

        public async Task<CategoryModel> Create(CategoryModel model)
        {
            try
            {
                CategoryEntity entity = new CategoryEntity().FromModel(model);
                _db.Categories.Add(entity);
                await _db.SaveChangesAsync();
                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating Category", e);
            }
        }

        public async Task<CategoryModel> Update(int id, CategoryModel model)
        {
            CategoryEntity? entity = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new Exception("Category not found!");
            }

            try
            {
                entity.UpdatePropsFromModel(model);

                _db.Entry(entity).State = EntityState.Modified;
                await _db.SaveChangesAsync();

                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error updating Category", e);
            }
        }

        public async Task<int> Delete(int id)
        {
            CategoryEntity? CategoryEntity = await _db.Categories.FindAsync(id);

            if (CategoryEntity == null)
            {
                throw new Exception("Category not found!");
            }

            try
            {
                _db.Categories.Remove(CategoryEntity);

                await _db.SaveChangesAsync();

                return id;
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Category", e);
            }
        }


    }
}
