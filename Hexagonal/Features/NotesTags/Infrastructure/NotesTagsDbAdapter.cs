using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;
using Hexagonal.Shared.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Features.NotesTags.Infrastructure
{
    public class NotesTagsDbAdapter: INotesTagsDbAdapterPort
    {
        private readonly AppDbContext _db;

        public NotesTagsDbAdapter(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<NotesTagsModel>> FindAll()
        {
            List<NotesTagsModel> NotesTags = await _db.NotesTags
                .Select(x => x.ToModel())
                .ToListAsync();

            return NotesTags;
        }

        public async Task<NotesTagsModel?> FindById(int id)
        {
            NotesTagsEntity? notesTagsFound = await _db.NotesTags
                .FirstOrDefaultAsync(i => i.Id == id);

            var notesTagsModel = notesTagsFound?.ToModel();

            return notesTagsModel;
        }

        public async Task<NotesTagsModel> Create(NotesTagsModel model)
        {
            try
            {
                NotesTagsEntity entity = new NotesTagsEntity().FromModel(model);
                _db.NotesTags.Add(entity);
                await _db.SaveChangesAsync();
                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating NotesTags", e);
            }
        }

        public async Task<NotesTagsModel> Update(int id, NotesTagsModel model)
        {
            NotesTagsEntity? entity = await _db.NotesTags.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new Exception("NotesTags not found!");
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
                throw new Exception("Error updating NotesTags", e);
            }
        }

        public async Task<int> Delete(int id)
        {
            NotesTagsEntity? NotesTagsEntity = await _db.NotesTags.FindAsync(id);

            if (NotesTagsEntity == null)
            {
                throw new Exception("NotesTags not found!");
            }

            try
            {
                _db.NotesTags.Remove(NotesTagsEntity);

                await _db.SaveChangesAsync();

                return id;
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting NotesTags", e);
            }
        }


    }
}
