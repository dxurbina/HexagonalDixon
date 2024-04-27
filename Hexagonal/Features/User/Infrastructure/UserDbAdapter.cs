using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain.Ports.Out;
using Hexagonal.Shared.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Features.User.Infrastructure
{
    public class UserDbAdapter: IUserDbAdapterPort
    {
        private readonly AppDbContext _db;

        public UserDbAdapter(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<UserModel>> FindAll()
        {
            List<UserModel> users = await _db.Users
                .Select(x => x.ToModel())
                .ToListAsync();

            return users;
        }

        public async Task<UserModel?> FindById(int id)
        {
            UserEntity? userFound = await _db.Users
                .FirstOrDefaultAsync(i => i.Id == id);

            var userModel = userFound?.ToModel();

            return userModel;
        }

        public async Task<UserModel?> FindByEmail(string email)
        {
            UserEntity? userFound = await _db.Users
                .FirstOrDefaultAsync(i => i.Email == email);

            if (userFound == null) return null;

            var userModel = userFound.ToModel();

            return userModel;
        }

        public async Task<UserModel> Create(UserModel user)
        {
            try
            {
                UserEntity entity = new UserEntity().FromModel(user);
                _db.Users.Add(entity);
                await _db.SaveChangesAsync();
                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error creating user", e);
            }
        }

        public async Task<UserModel> Update(int id, UserModel user)
        {
            UserEntity? entity = await _db.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new Exception("User not found!");
            }

            try
            {
                entity.UpdatePropsFromModel(user);

                _db.Entry(entity).State = EntityState.Modified;
                await _db.SaveChangesAsync();

                return entity.ToModel();
            }
            catch (Exception e)
            {
                throw new Exception("Error updating user", e);
            }
        }

        public async Task<int> Delete(int id)
        {
            UserEntity? userEntity = await _db.Users.FindAsync(id);

            if (userEntity == null)
            {
                throw new Exception("User not found!");
            }

            try
            {
                _db.Users.Remove(userEntity);

                await _db.SaveChangesAsync();

                return id;
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting user", e);
            }
        }


    }
}
