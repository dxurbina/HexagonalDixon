using Hexagonal.Features.User.Domain.Models;

namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface IGetUserById
    {
        Task<UserModel?> GetUserById(int id);
    }
}
