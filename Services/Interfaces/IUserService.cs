using GymBro_Backend_API.DTOs;
using GymBro_Backend_API.Models;

namespace GymBro_Backend_API.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> AddUserAsync(CreateUserDto createUserDto);
        Task<User> UpdateUserAsync(UpdateUserDto updateUserDto);
        Task DeleteUserAsync(Guid id);
        Task<User> GetUserAsync(Guid id);
    }
}
