namespace Hexagonal.Features.NotesTags.Domain.Ports.In
{
    public interface IDeleteNotesTags
    {
        Task<int> Delete(int id);
    }

}
