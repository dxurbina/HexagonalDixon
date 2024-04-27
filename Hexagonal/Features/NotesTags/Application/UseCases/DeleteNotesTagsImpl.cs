using Hexagonal.Features.NotesTags.Domain.Ports.In;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;

namespace Hexagonal.Features.NotesTags.Application.UseCases
{
    public class DeleteNotesTagsImpl : IDeleteNotesTags
    {
        private readonly INotesTagsDbAdapterPort _adapter;

        public DeleteNotesTagsImpl(INotesTagsDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<int> Delete(int id)
        {
            return _adapter.Delete(id);
        }

    }
}
