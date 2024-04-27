using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Domain.Ports.In;
using Hexagonal.Features.Note.Domain.Ports.Out;

namespace Hexagonal.Features.Note.Application.UseCases
{
    public class CreateNoteImpl : ICreateNote
    {
        private readonly INoteDbAdapterPort _adapter;

        public CreateNoteImpl(INoteDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<NoteModel> Create(NoteModel Note)
        {
            return _adapter.Create(Note);
        }

    }
}
