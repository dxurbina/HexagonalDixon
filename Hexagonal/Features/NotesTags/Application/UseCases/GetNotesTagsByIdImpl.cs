using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Ports.In;
using Hexagonal.Features.NotesTags.Domain.Ports.Out;

namespace Hexagonal.Features.NotesTags.Application.UseCases
{
    public class GetNotesTagsByIdImpl : IGetNotesTagsById
    {
        private readonly INotesTagsDbAdapterPort _adapter;

        public GetNotesTagsByIdImpl(INotesTagsDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<NotesTagsModel> GetNotesTagsById(int id)
        {
            return _adapter.FindById(id);
        }
    }
}
