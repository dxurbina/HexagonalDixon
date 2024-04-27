namespace Hexagonal.Features.Tag.Domain.Ports.In
{
    public interface IDeleteTag
    {
        Task<int> Delete(int id);
    }

}
