using Hexagonal.Features.Note.Domain.Models;
using Hexagonal.Features.Note.Domain.Ports.In;

namespace Hexagonal.Features.Note.Application.Services
{
    public class NoteService: INoteServicePort
    {
        private readonly IGetNoteById _getNoteByIdService;
        private readonly IGetNotes _getNotesService;
        private readonly ICreateNote _createNote;
        private readonly IUpdateNote _updateNote;
        private readonly IDeleteNote _deleteNote;


        public NoteService(IGetNoteById getNoteByIdService, IGetNotes getNotesService, ICreateNote createNote, IUpdateNote updateNote, IDeleteNote deleteNote)
        {
            _getNoteByIdService = getNoteByIdService;
            _getNotesService = getNotesService;
            _createNote = createNote;
            _updateNote = updateNote;
            _deleteNote = deleteNote;
        }

        public Task<List<NoteModel>> GetNotes()
        {
            return _getNotesService.GetNotes();
        }

        public Task<NoteModel?> GetNoteById(int id)
        {
            return _getNoteByIdService.GetNoteById(id);
        }

        public Task<NoteModel> Create(NoteModel Note)
        {
            return _createNote.Create(Note);
        }

        public Task<NoteModel> Update(int id, NoteModel Note)
        {
            return _updateNote.Update(id, Note);
        }

        public Task<int> Delete(int id)
        {
            return _deleteNote.Delete(id);
        }


    }
}
