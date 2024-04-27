using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Ports.Out;

namespace Hexagonal.Features.User.Application.UseCases
{
    public class DeleteUserImpl : IDeleteUser
    {
        private readonly IUserDbAdapterPort _adapter;

        public DeleteUserImpl(IUserDbAdapterPort adapter)
        {
            _adapter = adapter;
        }

        public Task<int> Delete(int id)
        {
            return _adapter.Delete(id);
        }

    }
}
