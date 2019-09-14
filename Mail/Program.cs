using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Mail
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new MailMessage("senior.t34@yandex.ru", "smektamp@gmail.com");
            message.Subject = "Ваш комп включился";
            message.Body = $"Он включился в {DateTime.Now}";

            var client = new SmtpClient("smtp.yandex.ru");
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("senior.t34@yandex.ru", "MaX333000");

            client.Send(message);

           
        }
    }
}
