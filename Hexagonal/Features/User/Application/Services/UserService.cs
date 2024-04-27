using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.In;

namespace Hexagonal.Features.User.Application.Services
{
    public class UserService: IUserServicePort
    {
        private readonly IGetUserById _getUSerByIdService;
        private readonly IGetUsers _getUSersService;
        private readonly ICreateUser _createUser;
        private readonly IUpdateUser _updateUser;
        private readonly IDeleteUser _deleteUser;

        public UserService(IGetUserById getUSerByIdService, IGetUsers getUSersService, ICreateUser createUser, IUpdateUser updateUser, IDeleteUser deleteUser)
        {
            _getUSerByIdService = getUSerByIdService;
            _getUSersService = getUSersService;
            _createUser = createUser;
            _updateUser = updateUser;
            _deleteUser = deleteUser;
        }

        public Task<List<UserModel>> GetUsers()
        {
            return _getUSersService.GetUsers();
        }

        public Task<UserModel?> GetUserById(int id)
        {
            return _getUSerByIdService.GetUserById(id);
        }

        public Task<UserModel> Create(UserModel user)
        {
            return _createUser.Create(user);
        }

        public Task<UserModel> Update(int id, UserModel User)
        {
            return _updateUser.Update(id, User);
        }

        public Task<int> Delete(int id)
        {
            return _deleteUser.Delete(id);
        }

    }
}
