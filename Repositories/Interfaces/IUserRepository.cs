using GymBro_Backend_API.Models;

namespace GymBro_Backend_API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User> GetAsync(int id);

    }
}
