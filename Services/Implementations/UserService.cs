using AutoMapper;
using BCrypt.Net;
using GymBro_Backend_API.DTOs;
using GymBro_Backend_API.Models;
using GymBro_Backend_API.Repositories.Interfaces;
using GymBro_Backend_API.Services.Interfaces;

namespace GymBro_Backend_API.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<User> AddUserAsync(CreateUserDto createUserDto)
        { 
            var user = _mapper.Map<User>(createUserDto);

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password);

            var created =  await _userRepository.AddAsync(user);

            return created;
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<User> UpdateUserAsync(UpdateUserDto updateUserDto)
        {
            var existing = await _userRepository.GetAsync(updateUserDto.Id);

            _mapper.Map(updateUserDto, existing);

            var updated = await _userRepository.UpdateAsync(existing);

            return updated;

        }
    }
}
