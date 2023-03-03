using ProiectTest.Data;
using ProiectTest.Models;

namespace ProiectTest.UserRepositoryy
{
    public class UserRepository : GenericRepository.GenericRepository<User>, IUserRepository
    {
        public UserRepository(ProiectTestContext context) : base(context)
        {
        }

        public User FindByUserName(string userName)
        {
            return _table.FirstOrDefault(x => x.UserName == userName);
        }
    }
}