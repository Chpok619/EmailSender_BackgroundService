using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace EmailSender;
public class Sender: ISender
{
    public void SendLetter()
    {
            MailAddress from = new MailAddress("testmesharp@mail.ru", ".Net");
            MailAddress to = new MailAddress("testmesharp@mail.ru");

            MailMessage message = new MailMessage(from, to);
            message.Body = $"<h1 style=\"color: red\">{Process.GetCurrentProcess().WorkingSet64} bytes</h1>";
            message.Subject = "Test email service";
            message.IsBodyHtml = true;
        
            SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
            client.Credentials = new NetworkCredential("testmesharp@mail.ru", "0bh6nqikiAvG8zFJETWA");
            client.EnableSsl = true;
            client.Send(message);
    }
    
    public void SendLetter(string from, string to, string mess)
    {
        // MailAddress from = new MailAddress("testmesharp@mail.ru", ".Net");
        // MailAddress to = new MailAddress("testmesharp@mail.ru");

        MailMessage message = new MailMessage(from, to);
        message.Body = $"<h1 style=\"color: red\">{mess}</h1>";
        message.Subject = "Test email service";
        message.IsBodyHtml = true;
        
        SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
        client.Credentials = new NetworkCredential("testmesharp@mail.ru", "0bh6nqikiAvG8zFJETWA");
        client.EnableSsl = true;
        client.Send(message);
    }
}