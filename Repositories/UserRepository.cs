using ASP_CORE_BASIC_NET_6_API.Data;
using ASP_CORE_BASIC_NET_6_API.Models.Domain;
using ASP_CORE_BASIC_NET_6_API.Repositories.Interfaces;

namespace ASP_CORE_BASIC_NET_6_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContextBase _dbContext;

        public UserRepository(DBContextBase dBContext)
        {
            this._dbContext = dBContext;
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }
    }
}
