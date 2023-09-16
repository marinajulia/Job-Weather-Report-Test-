using Hangfire;
using Hangfire.MemoryStorage;
using Job_Weather_Report.Interfaces.User;
using Job_Weather_Report.Interfaces.WeatherReport;
using Job_Weather_Report.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Job_Weather_Report
{
    public class Startup
    {
        private static IUserService _userService;
        private static IWeatherReportService _weatherReportService;
        private readonly Job jobscheduler = new Job(_userService, _weatherReportService);
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Resolve();

            services.AddHangfire(op =>
            {
                op.UseMemoryStorage();
            });
            services.AddHangfireServer();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHangfireDashboard();
            RecurringJob.AddOrUpdate(() => jobscheduler.Execute(), Cron.Daily);
        }
    }
}
