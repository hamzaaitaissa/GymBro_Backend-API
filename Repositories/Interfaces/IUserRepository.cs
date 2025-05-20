using GymBro_Backend_API.Models;

namespace GymBro_Backend_API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(Guid id);
        Task<User> GetAsync(Guid id);

    }
}
