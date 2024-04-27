using Hexagonal.Features.NotesTags.Domain.Models;

namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public interface IUpdateNotesTags
    {
        Task<NotesTagsModel> Update(int id, NotesTagsModel notesTags);

    }
}
