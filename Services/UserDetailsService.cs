using ASP_CORE_BASIC_NET_6_API.Models.DTOs;
using ASP_CORE_BASIC_NET_6_API.Repositories.Interfaces;
using ASP_CORE_BASIC_NET_6_API.Services.Interfaces;
using AutoMapper;

namespace ASP_CORE_BASIC_NET_6_API.Services
{
    public class UserDetailsService: IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetailsRepository;
        private readonly IMapper _mapper;

        public UserDetailsService(IUserDetailsRepository userDetailsRepository, IMapper mapper)
        {
            this._userDetailsRepository = userDetailsRepository;
            this._mapper = mapper;
        }

        public List<UserDetailsDTO> GetAllUserDetails()
        {
            var allUsersDetails = _userDetailsRepository.GetAll();
            var allUsersDetailsDTOs = _mapper.Map<List<UserDetailsDTO>>(allUsersDetails);

            return allUsersDetailsDTOs;
        }
    }
}
