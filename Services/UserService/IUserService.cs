using ProiectTest.Models.DTOs;

namespace ProiectTest.Services.UserService
{
    public interface IUserService
    {
        UserResponseDTO Authenticate(UserRequestDTO model);
        UserRequestDTO GetById(Guid id);
        Task Create(UserRequestDTO newUser); 
    }
}