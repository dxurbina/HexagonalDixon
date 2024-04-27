namespace Hexagonal.Features.Note.Domain.Ports.In
{
    public interface IDeleteNote
    {
        Task<int> Delete(int id);
    }

}
