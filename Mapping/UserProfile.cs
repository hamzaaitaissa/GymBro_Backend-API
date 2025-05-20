using AutoMapper;
using GymBro_Backend_API.DTOs;
using GymBro_Backend_API.Models;

namespace GymBro_Backend_API.Mapping
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            // imma hash the psd seperately
            CreateMap<CreateUserDto, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

            CreateMap<UpdateUserDto, User>()
               .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

           
        }
    }
}
