using Job_Weather_Report.Interfaces.User;
using Job_Weather_Report.Interfaces.WeatherReport;
using Job_Weather_Report.Services.User;
using Job_Weather_Report.Services.WeatherReport;
using Microsoft.Extensions.DependencyInjection;
using WeatherReportJobInfra.Infra.Data;
using WeatherReportJobInfra.Infra.Interfaces.User;
using WeatherReportJobInfra.Infra.Interfaces.WeatherReport;
using WeatherReportJobInfra.Infra.Repositories.User;
using WeatherReportJobInfra.Infra.Repositories.WeatherReport;

namespace Job_Weather_Report.IoC
{
    public static class DependencyResolver
    {
        public static void Resolve(this IServiceCollection services)
        {
            //var mappingConfig = new MapperConfiguration(m =>
            //{
            //    m.AddProfile(new AutoMapperProfile());
            //});

            //var mapper = mappingConfig.CreateMapper();
            //services.AddSingleton(mapper);

            services.AddDbContext<ApplicationContext>();

            Context(services);
            Repositories(services);
            Services(services);
        }
        public static void Context(IServiceCollection services)
        {
            services.AddScoped<ApplicationContext, ApplicationContext>();
        }
        public static void Repositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWeatherReportRepository, WeatherReportRepository>();
        }
        public static void Services(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWeatherReportService, WeatherReportService>();
        }
    }
}
