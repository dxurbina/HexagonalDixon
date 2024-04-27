using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;

namespace Hexagonal.Features.User.Application.UseCases
{
    public class CreateUserImpl : ICreateUser
    {
        private readonly IUserDbAdapterPort _adapter;

        public CreateUserImpl(IUserDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<UserModel> Create(UserModel user)
        {
            return _adapter.Create(user);
        }

    }
}
