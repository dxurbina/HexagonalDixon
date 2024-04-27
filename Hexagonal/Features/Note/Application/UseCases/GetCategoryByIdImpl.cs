using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Domain.Ports.In;
using Hexagonal.Features.Note.Domain.Ports.Out;

namespace Hexagonal.Features.Note.Application.UseCases
{
    public class GetNoteByIdImpl : IGetNoteById
    {
        private readonly INoteDbAdapterPort _adapter;

        public GetNoteByIdImpl(INoteDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<NoteModel> GetNoteById(int id)
        {
            return _adapter.FindById(id);
        }
    }
}
