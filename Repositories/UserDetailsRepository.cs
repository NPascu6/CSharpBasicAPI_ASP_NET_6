using ASP_CORE_BASIC_NET_6_API.Data;
using ASP_CORE_BASIC_NET_6_API.Models.Domain;
using ASP_CORE_BASIC_NET_6_API.Repositories.Interfaces;

namespace ASP_CORE_BASIC_NET_6_API.Repositories
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly DBContextBase _dbContext;

        public UserDetailsRepository(DBContextBase dBContext)
        {
            this._dbContext = dBContext;
        }

        public IEnumerable<UserDetails> GetAll()
        {
            return _dbContext.UserDetails.ToList();
        }
        public UserDetails? GetByUserId(Guid id)
        {
            return _dbContext.UserDetails.FirstOrDefault(userDetails => userDetails.UserId == id);
        }

    }
}
