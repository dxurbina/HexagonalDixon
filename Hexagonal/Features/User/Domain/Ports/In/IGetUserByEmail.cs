using Hexagonal.Features.User.Domain.Models;

namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface IGetUserByEmail
    {
        Task<UserModel?> GetUserByEmail(string email);
    }
}

