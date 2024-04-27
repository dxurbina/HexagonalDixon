using Hexagonal.Features.NotesTags.Domain.Models;

namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public interface ICreateNotesTags
    {
        Task<NotesTagsModel> Create(NotesTagsModel notesTags);
    }

}
