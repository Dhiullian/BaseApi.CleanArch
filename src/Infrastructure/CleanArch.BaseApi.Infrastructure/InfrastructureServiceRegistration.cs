using CleanArch.BaseApi.Application.Interfaces.Infrastructure;
using CleanArch.BaseApi.Application.ServiceModel.Mail;
using CleanArch.BaseApi.Infrastructure.FileExport;
using CleanArch.BaseApi.Infrastructure.MailService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.BaseApi.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
