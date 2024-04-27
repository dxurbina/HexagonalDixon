using Hexagonal.Features.Note.Domain.Ports.In;
using Hexagonal.Features.Note.Domain.Ports.Out;

namespace Hexagonal.Features.Note.Application.UseCases
{
    public class DeleteNoteImpl : IDeleteNote
    {
        private readonly INoteDbAdapterPort _adapter;

        public DeleteNoteImpl(INoteDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<int> Delete(int id)
        {
            return _adapter.Delete(id);
        }

    }
}
