namespace Hexagonal.Features.User.Domain
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(int id) : base($"User with id {id} not found")
        {
        }
        public UserNotFoundException(string email) : base($"User with email {email} not found")
        {
        }
    }
}