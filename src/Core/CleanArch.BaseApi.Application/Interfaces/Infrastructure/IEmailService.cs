using CleanArch.BaseApi.Application.ServiceModel.Mail;
using System.Threading.Tasks;

namespace CleanArch.BaseApi.Application.Interfaces.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
