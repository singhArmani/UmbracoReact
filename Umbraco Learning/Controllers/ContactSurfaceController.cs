using System.Net.Mail;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco_Learning.UmbracoLearning.Domain.Content;

namespace Umbraco_Learning.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Contact/";

        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Contact.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ContactModel model)
        {
            if(ModelState.IsValid)
            {
                SendEmail(model);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }

        private void SendEmail(ContactModel model)
        {
            MailMessage message = new MailMessage(model.EmailAddress, "amandeep.singh@4mation.com.au");
            message.Subject = string.Format("Enquiry from {0}, {1} - {2}", model.FirstName, model.LastName, model.EmailAddress);
            message.Body = model.Message;

            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}