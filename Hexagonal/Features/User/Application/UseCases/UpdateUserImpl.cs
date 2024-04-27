using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;

namespace Hexagonal.Features.User.Application.UseCases
{
    public class UpdateUserImpl: IUpdateUser
    {
        private readonly IUserDbAdapterPort _adapter;

        public UpdateUserImpl(IUserDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<UserModel> Update(int id, UserModel user)
        {
            return _adapter.Update(id, user);
        }

    }
}
