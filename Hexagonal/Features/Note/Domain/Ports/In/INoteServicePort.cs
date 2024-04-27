namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public interface INoteServicePort : IGetNotes, IGetNoteById, ICreateNote, IUpdateNote, IDeleteNote
    {
    }
}
