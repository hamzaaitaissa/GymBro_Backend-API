using GymBro_Backend_API.Data;
using GymBro_Backend_API.Models;
using GymBro_Backend_API.Repositories.Interfaces;

namespace GymBro_Backend_API.Repositories.Implementations
{
    public class UserRepository: IUserRepository
    {
        private readonly GymBroDbContext _gymBroDbContext;

        public UserRepository(GymBroDbContext gymBroDbContext)
        {
            _gymBroDbContext = gymBroDbContext;
        }

        public async Task<User> AddAsync(User user)
        {
            await _gymBroDbContext.AddAsync(user);
            await _gymBroDbContext.SaveChangesAsync();
            return user;
        }

        public async Task DeleteAsync(int id)
        {
             var user = await _gymBroDbContext.Users.FindAsync(id);
            if (user != null)
            {
                _gymBroDbContext.Users.Remove(user);
                await _gymBroDbContext.SaveChangesAsync();
            }
        }

        public async Task<User> GetAsync(int id)
        {
            var user = await _gymBroDbContext.Users.FindAsync(id);
            return user;
        }

        public async Task<User> UpdateAsync(User user)
        {
            _gymBroDbContext.Users.Update(user);
            await _gymBroDbContext.SaveChangesAsync() ;
            return user;
        }
    }
}
