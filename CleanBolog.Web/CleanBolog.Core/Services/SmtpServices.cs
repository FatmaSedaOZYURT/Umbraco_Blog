using CleanBolog.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Logging;

namespace CleanBolog.Core.Services
{
    public class SmtpServices : ISmtpServices
    {
        readonly ILogger _logger;
        public SmtpServices(ILogger logger)
        {
            _logger = logger;
        }
        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                string toAddress = "fsedaozyurt@gmail.com";
                string fromAddress = model.Email;

                mail.Subject = $"Enquiry from: {model.Name} - {model.Email}";
                mail.Body = model.Message;
                mail.To.Add(new MailAddress(toAddress, toAddress));
                mail.From = new MailAddress(fromAddress, fromAddress);

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactViewModel), ex, ex.Message);
                return false;
            }
        }
    }
}
