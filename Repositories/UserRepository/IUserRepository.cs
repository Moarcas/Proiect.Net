using ProiectTest.GenericRepository;
using ProiectTest.Models;

namespace ProiectTest.UserRepositoryy
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUserName(string userName);   
    }
}