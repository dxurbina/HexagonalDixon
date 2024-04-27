using Hexagonal.Features.Note.Domain.Models;

namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public interface ICreateNote
    {
        Task<NoteModel> Create(NoteModel Note);
    }

}
