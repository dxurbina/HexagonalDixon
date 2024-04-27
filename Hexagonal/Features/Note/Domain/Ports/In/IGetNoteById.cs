using Hexagonal.Features.Note.Domain.Models;

namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public interface IGetNoteById
    {
        Task<NoteModel?> GetNoteById(int id);
    }
}
