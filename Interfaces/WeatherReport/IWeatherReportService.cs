using System.Threading.Tasks;
using WeatherReportJobInfra.Infra.Entities;

namespace Job_Weather_Report.Interfaces.WeatherReport
{
    public interface IWeatherReportService
    {
        Task<WeatherReportEntity> GetWeatherReport(string cityId);
        void PostWeather(UserWeatherEntity weatherReport);
    }
}
