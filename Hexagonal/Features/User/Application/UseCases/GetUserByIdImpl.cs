using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;

namespace Hexagonal.Features.User.Application.UseCases
{
    public class GetUserByIdImpl : IGetUserById
    {
        private readonly IUserDbAdapterPort _adapter;

        public GetUserByIdImpl(IUserDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<UserModel> GetUserById(int id)
        {
            return _adapter.FindById(id);
        }
    }
}
