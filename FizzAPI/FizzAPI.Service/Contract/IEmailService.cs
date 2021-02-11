using FizzAPI.Domain.Settings;
using System.Threading.Tasks;

namespace FizzAPI.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
