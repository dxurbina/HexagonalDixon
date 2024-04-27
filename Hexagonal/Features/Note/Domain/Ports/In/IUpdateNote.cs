using Hexagonal.Features.Note.Domain.Models;

namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public interface IUpdateNote
    {
        Task<NoteModel> Update(int id, NoteModel Note);

    }
}
