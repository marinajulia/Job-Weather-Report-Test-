﻿using Job_Weather_Report.Interfaces.WeatherReport;
using System.Threading.Tasks;
using WeatherReportJobInfra.Infra.Entities;
using WeatherReportJobInfra.Infra.Interfaces.WeatherReport;

namespace Job_Weather_Report.Services.WeatherReport
{
    public class WeatherReportService : IWeatherReportService
    {
        private readonly IWeatherReportRepository _weatherReportRepository;
        public WeatherReportService(IWeatherReportRepository weatherReportRepository)
        {
            _weatherReportRepository = weatherReportRepository;
        }

        public async Task<WeatherReportEntity> GetWeatherReport(string cityId)
        {
            //TODO: tratar retorno para caso não encontre
            return await _weatherReportRepository.GetWeatherReport(cityId);
        }

        public void PostWeather(UserWeatherEntity weatherReport)
        {
            _weatherReportRepository.PostWeather(weatherReport);
        }
    }
}
