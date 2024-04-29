using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Shared.Domain.Ports.Out;

namespace Hexagonal.Features.Note.Domain.Ports.Out
{
    public interface INoteDbAdapterPort : IDbCrudAdapter<NoteModel>
    {
    }
}
