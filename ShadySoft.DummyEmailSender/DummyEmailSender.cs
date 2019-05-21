using Microsoft.AspNetCore.Identity.UI.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ShadySoft.DummyEmailSender
{
    public class DummyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Debug.WriteLine("************************************************");
            Debug.WriteLine($"Recipient: {email}");
            Debug.WriteLine("************************************************");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine("************************************************");
            Debug.WriteLine(htmlMessage);

            return Task.CompletedTask;
        }
    }
}
