using System;
using System.Net.Mail;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using CleanBolog.Core.Services;
using CleanBolog.Core.ViewModels;
using Umbraco.Core.Logging;
using Umbraco.Web;

namespace CleanBolog.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        ISmtpServices _smtpService;
        public ContactSurfaceController(ISmtpServices smtpService)
        {
            _smtpService = smtpService;
        }
        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel() { ContactFormID = CurrentPage.Id };//açık olan sayfaın id sini alırız.

            return PartialView("~/Views/Partials/Contact/contact.cshtml",model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView("~/Views/Partials/Contact/contact.cshtml", model);
        }

        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;

            if (ModelState.IsValid)
            {
                success = _smtpService.SendEmail(model);
            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormID);

            var successMessage = contactPage.Value<IHtmlString>("successMessage");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessage");

            return PartialView("~/Views/Partials/Contact/result.cshtml", success ? successMessage : errorMessage);
        }
    }
}
