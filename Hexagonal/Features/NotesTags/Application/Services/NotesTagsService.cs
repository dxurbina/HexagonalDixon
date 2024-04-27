using Hexagonal.Features.NotesTags.Domain.Models;
using Hexagonal.Features.NotesTags.Domain.Ports.In;

namespace Hexagonal.Features.NotesTags.Application.Services
{
    public class NotesTagsService: INotesTagsServicePort
    {
        private readonly IGetNotesTagsById _getNotesTagsByIdService;
        private readonly IGetNotesTags _getNotesTagsService;
        private readonly ICreateNotesTags _createNotesTags;
        private readonly IUpdateNotesTags _updateNotesTags;
        private readonly IDeleteNotesTags _deleteNotesTags;


        public NotesTagsService(IGetNotesTagsById getNotesTagsByIdService, IGetNotesTags getNotesTagsService, ICreateNotesTags createNotesTags, IUpdateNotesTags updateNotesTags, IDeleteNotesTags deleteNotesTags)
        {
            _getNotesTagsByIdService = getNotesTagsByIdService;
            _getNotesTagsService = getNotesTagsService;
            _createNotesTags = createNotesTags;
            _updateNotesTags = updateNotesTags;
            _deleteNotesTags = deleteNotesTags;
        }

        public Task<List<NotesTagsModel>> GetNotesTags()
        {
            return _getNotesTagsService.GetNotesTags();
        }

        public Task<NotesTagsModel?> GetNotesTagsById(int id)
        {
            return _getNotesTagsByIdService.GetNotesTagsById(id);
        }

        public Task<NotesTagsModel> Create(NotesTagsModel notesTags)
        {
            return _createNotesTags.Create(notesTags);
        }

        public Task<NotesTagsModel> Update(int id, NotesTagsModel notesTags)
        {
            return _updateNotesTags.Update(id, notesTags);
        }

        public Task<int> Delete(int id)
        {
            return _deleteNotesTags.Delete(id);
        }


    }
}
