using Hexagonal.Features.User.Domain.Models;

namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface IGetUsers
    {
        Task<List<UserModel>> GetUsers();
    }
}