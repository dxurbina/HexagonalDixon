using Hexagonal.Features.User.Domain.Models;

namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface IUpdateUser
    {
        Task<UserModel> Update(int id, UserModel user);

    }
}

