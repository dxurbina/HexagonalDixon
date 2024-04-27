namespace Hexagonal.Features.User.Domain.Ports.In
{
    public interface IUserServicePort : IGetUsers, IGetUserById, ICreateUser, IUpdateUser, IDeleteUser
    {
    }
}
