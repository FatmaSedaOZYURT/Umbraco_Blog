using CleanBolog.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBolog.Core.Services
{
    public interface ISmtpServices
    {
        bool SendEmail(ContactViewModel model);
    }
}
