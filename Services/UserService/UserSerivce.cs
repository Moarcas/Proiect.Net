using AutoMapper;
using ProiectTest.Helper.JwtUtils;
using ProiectTest.Models.DTOs;
using ProiectTest.UserRepositoryy;
using BCrypt.Net; 

namespace ProiectTest.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IJwtUtils _jwtUtils;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }

        public UserResponseDTO Authenticate(UserRequestDTO model)
        { 
            var user = _userRepository.FindByUserName(model.UserName);

            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            {
                return null;
            }
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public Task Create(UserRequestDTO newUser)
        {
            throw new NotImplementedException();
        }

        public UserRequestDTO GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}