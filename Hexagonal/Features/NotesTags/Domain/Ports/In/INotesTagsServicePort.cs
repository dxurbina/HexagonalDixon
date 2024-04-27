namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public interface INotesTagsServicePort : IGetNotesTags, IGetNotesTagsById, ICreateNotesTags, IUpdateNotesTags, IDeleteNotesTags
    {
    }
}
