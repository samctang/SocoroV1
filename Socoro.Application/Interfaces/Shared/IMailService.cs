using Socoro.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}