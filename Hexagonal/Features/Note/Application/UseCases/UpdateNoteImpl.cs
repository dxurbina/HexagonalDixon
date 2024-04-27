using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Domain.Ports.In;
using Hexagonal.Features.Note.Domain.Ports.Out;

namespace Hexagonal.Features.Note.Application.UseCases
{
    public class UpdateNoteImpl : IUpdateNote
    {
        private readonly INoteDbAdapterPort _adapter;

        public UpdateNoteImpl(INoteDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<NoteModel> Update(int id, NoteModel Note)
        {
            return _adapter.Update(id, Note);
        }

    }
}
