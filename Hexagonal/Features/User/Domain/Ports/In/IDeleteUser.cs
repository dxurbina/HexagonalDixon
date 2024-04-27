namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface IDeleteUser
    {
        Task<int> Delete(int id);
    }
}
