using Hexagonal.Features.NotesTags.Domain.Models;

namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public interface IGetNotesTags
    {
        Task<List<NotesTagsModel>> GetNotesTags();
    }
}