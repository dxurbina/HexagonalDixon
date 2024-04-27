using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;

namespace Hexagonal.Features.User.Application.UseCases
{
    public class GetUserByEmailImpl : IGetUserByEmail
    {
        private readonly IUserDbAdapterPort _adapter;

        public GetUserByEmailImpl(IUserDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<UserModel?> GetUserByEmail(string email)
        {
            return _adapter.FindByEmail(email);
        }
    }

}
