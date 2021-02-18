using System;
using System.Net;
using System.Net.Mail;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new MailAddress("N916-138-9890@yandex.ru", "Софья");
            var to = new MailAddress("n9161389890@gmail.com", "Софья");

            var message = new MailMessage(from, to);
            message.Subject = "Заголовок";
            message.Body = "Текст письма";

            var client = new SmtpClient("smtp.yandex.ru", 465);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = "UserName",
                //SecurePassword = ""
                Password = "Password!"
            };

            client.Send(message);
        }
    }
}
