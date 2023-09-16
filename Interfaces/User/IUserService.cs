using System.Collections.Generic;
using WeatherReportJobInfra.Infra.Entities;

namespace Job_Weather_Report.Interfaces.User
{
    public interface IUserService
    {
        IEnumerable<UserEntity> Get();
    }
}
