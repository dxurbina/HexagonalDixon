using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Ports.In;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;

namespace Hexagonal.Features.NotesTags.Application.UseCases
{
    public class UpdateNotesTagsImpl : IUpdateNotesTags
    {
        private readonly INotesTagsDbAdapterPort _adapter;

        public UpdateNotesTagsImpl(INotesTagsDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<NotesTagsModel> Update(int id, NotesTagsModel notesTags)
        {
            return _adapter.Update(id, notesTags);
        }

    }
}
