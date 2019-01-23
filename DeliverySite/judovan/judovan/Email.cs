using System;
using System.Net.Mail;

namespace judovan
{
    public class Email
    {
        private string _Email = null;
        public Email(string Email)
        {
            this._Email = Email;
        }
        public void CreateTestMessage3(string userEmail, String subject, String content)
        {
            MailAddress to = new MailAddress(userEmail);
            MailAddress from = new MailAddress("boxwear.co@gmail.com", "BOXWEAR");
            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;

            message.IsBodyHtml = true;
            message.Body = string.Format("<html><head></head><body><div style='margin: auto; width: 60%;'><img src='https://i.imgur.com/oxVEgf1.png' style='width:300px;height:auto;'></div><br/>" + content + "</body></html>");
            // Use the application or machine configuration to get the 
            // host, port, and credentials.
            SmtpClient client = new SmtpClient();
            Console.WriteLine("Sending an e-mail message to {0} at {1} by using the SMTP host={2}.",
                to.User, to.Host, client.Host);
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage3(): {0}",
                            ex.ToString());
            }
        }
    }
}