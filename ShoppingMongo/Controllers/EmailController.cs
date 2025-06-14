using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ShoppingMongo.Models;

namespace ShoppingMongo.Controllers
{
    public class EmailController : Controller
    {
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(AdminMailViewModel adminmailViewModel)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Coza Store", "koksemaa47@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", adminmailViewModel.Mail));

            mimeMessage.Subject = "Merhaba %20 İndirim Kuponunuz Bulunmaktadır 15 Gün İçinde Kullanabilirsiniz.";

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = "<h2>Teşekkür Ederiz</h2><p>Merhaba %20 İndirim Kuponunuz Bulunmaktadır 15 Gün İçinde Kullanabilirsiniz.</p><h3>Kupon Kodu: <strong>SEMA20</strong></h3><p>Mutlu alışverişler!</p>"
			};

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate("koksemaa47@gmail.com", "qswl mfjo zswy pgei");
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }

            return RedirectToAction("Index", "Defaultt");
        }
    }
}