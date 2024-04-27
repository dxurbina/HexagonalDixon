using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Domain.Ports.Out;

namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public class GetNotesImpl : IGetNotes
    {
        private readonly INoteDbAdapterPort _adapter;

        public GetNotesImpl(INoteDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<List<NoteModel>> GetNotes()
        {
            return _adapter.FindAll();
        }
    }

}
