using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Ports.In;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;

namespace Hexagonal.Features.NotesTags.Application.UseCases
{
    public class CreateNotesTagsImpl : ICreateNotesTags
    {
        private readonly INotesTagsDbAdapterPort _adapter;

        public CreateNotesTagsImpl(INotesTagsDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<NotesTagsModel> Create(NotesTagsModel notesTags)
        {
            return _adapter.Create(notesTags);
        }

    }
}
