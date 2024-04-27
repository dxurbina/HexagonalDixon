using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Domain.Ports.Out;
using Hexagonal.Shared.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Features.Note.Infrastructure
{
    public class NoteDbAdapter: INoteDbAdapterPort
    {
        private readonly AppDbContext _db;

        public NoteDbAdapter(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<NoteModel>> FindAll()
        {
            List<NoteModel> Notes = await _db.Notes
                .Select(x => x.ToModel())
                .ToListAsync();

            return Notes;
        }

        public async Task<NoteModel?> FindById(int id)
        {
            NoteEntity? noteFound = await _db.Notes
                .FirstOrDefaultAsync(i => i.Id == id);

            var noteModel = noteFound?.ToModel();

            return noteModel;
        }

        public async Task<NoteModel> Create(NoteModel model)
        {
            try
            {
                NoteEntity entity = new NoteEntity().FromModel(model);
                _db.Notes.Add(entity);
                await _db.SaveChangesAsync();
                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating Note", e);
            }
        }

        public async Task<NoteModel> Update(int id, NoteModel model)
        {
            NoteEntity? entity = await _db.Notes.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new Exception("Note not found!");
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
                throw new Exception("Error updating Note", e);
            }
        }

        public async Task<int> Delete(int id)
        {
            NoteEntity? NoteEntity = await _db.Notes.FindAsync(id);

            if (NoteEntity == null)
            {
                throw new Exception("Note not found!");
            }

            try
            {
                _db.Notes.Remove(NoteEntity);

                await _db.SaveChangesAsync();

                return id;
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting Note", e);
            }
        }


    }
}
