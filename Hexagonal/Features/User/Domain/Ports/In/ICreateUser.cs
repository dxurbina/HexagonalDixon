using Hexagonal.Features.Category.Domain.Models;
using Hexagonal.Features.User.Domain.Models;

namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface ICreateUser
    {
        Task<UserModel> Create(UserModel user);
    }
}
