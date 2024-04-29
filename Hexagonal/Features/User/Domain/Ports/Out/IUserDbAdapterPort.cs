using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Shared.Domain.Ports.Out;

namespace Hexagonal.Features.User.Domain.Ports.Out
{
    public interface IUserDbAdapterPort : IDbCrudAdapter<UserModel>
    {
        Task<UserModel?> FindByEmail(string email);
    }
}
