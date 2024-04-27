using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;

namespace Hexagonal.Features.User.Application.UseCases
{
    public class GetUsersImpl : IGetUsers
    {
        private readonly IUserDbAdapterPort _adapter;

        public GetUsersImpl(IUserDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<List<UserModel>> GetUsers()
        {
            return _adapter.FindAll();
        }
    }

}
