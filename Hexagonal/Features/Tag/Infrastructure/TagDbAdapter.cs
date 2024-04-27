using Hexagonal.Features.Tag.Domain.Models;
using Hexagonal.Features.Tag.Domain.Ports.Out;
using Hexagonal.Shared.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Features.Tag.Infrastructure
{
    public class TagDbAdapter: ITagDbAdapterPort
    {
        private readonly AppDbContext _db;

        public TagDbAdapter(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<TagModel>> FindAll()
        {
            List<TagModel> Tags = await _db.Tags
                .Select(x => x.ToModel())
                .ToListAsync();

            return Tags;
        }

        public async Task<TagModel?> FindById(int id)
        {
            TagEntity? tagFound = await _db.Tags
                .FirstOrDefaultAsync(i => i.Id == id);

            var tagModel = tagFound?.ToModel();

            return tagModel;
        }

        public async Task<TagModel> Create(TagModel model)
        {
            try
            {
                TagEntity entity = new TagEntity().FromModel(model);
                _db.Tags.Add(entity);
                await _db.SaveChangesAsync();
                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating Tag", e);
            }
        }

        public async Task<TagModel> Update(int id, TagModel model)
        {
            TagEntity? entity = await _db.Tags.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new Exception("Tag not found!");
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
                throw new Exception("Error updating Tag", e);
            }
        }

        public async Task<int> Delete(int id)
        {
            TagEntity? TagEntity = await _db.Tags.FindAsync(id);

            if (TagEntity == null)
            {
                throw new Exception("Tag not found!");
            }

            try
            {
                _db.Tags.Remove(TagEntity);

                await _db.SaveChangesAsync();

                return id;
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Tag", e);
            }
        }


    }
}
