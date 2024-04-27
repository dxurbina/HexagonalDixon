using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;

namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public class GetNotesTagsImpl : IGetNotesTags
    {
        private readonly INotesTagsDbAdapterPort _adapter;

        public GetNotesTagsImpl(INotesTagsDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<List<NotesTagsModel>> GetNotesTags()
        {
            return _adapter.FindAll();
        }
    }

}
