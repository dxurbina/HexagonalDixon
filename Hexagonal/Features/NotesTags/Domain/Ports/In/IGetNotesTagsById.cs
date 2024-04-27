using Hexagonal.Features.NotesTags.Domain.Models;

namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public interface IGetNotesTagsById
    {
        Task<NotesTagsModel?> GetNotesTagsById(int id);
    }
}
