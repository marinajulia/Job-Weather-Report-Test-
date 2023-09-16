using Job_Weather_Report.Interfaces.User;
using System.Collections.Generic;
using WeatherReportJobInfra.Infra.Entities;
using WeatherReportJobInfra.Infra.Interfaces.User;

namespace Job_Weather_Report.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserEntity> Get()
        {
            return _userRepository.Get();
        }
    }
}
