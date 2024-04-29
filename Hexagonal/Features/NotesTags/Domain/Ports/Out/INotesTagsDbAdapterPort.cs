using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Shared.Domain.Ports.Out;

namespace Hexagonal.Features.NotesTags.Domain.Ports.Out
{
    public interface INotesTagsDbAdapterPort : IDbCrudAdapter<NotesTagsModel>
    {
    }
}
