using Hexagonal.Features.Note.Domain.Models;

namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public interface IGetNotes
    {
        Task<List<NoteModel>> GetNotes();
    }
}