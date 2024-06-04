using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using Bicycle_DBMS;

namespace Bicycle_DBMS
{
    public class Email
    {
        string MyMailAdeess = "BicycleManageCompany@gmail.com";
        string Password = "udhdhdwqmrjqrreb";
        string Destination;
        string Subject;
        string MessageBody;

        public Email(string destination, string subject, string messageBody)
        {
            Destination = destination;
            Subject = subject;
            MessageBody = messageBody;
        }
        public void send()
        {
            try
            {
                using(SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(MyMailAdeess, Password);
                    MailMessage msgObj = new MailMessage();
                    msgObj.To.Add(Destination);
                    msgObj.From = new MailAddress(MyMailAdeess);
                    msgObj.Subject = Subject;
                    msgObj.Body = MessageBody;
                    client.Send(msgObj);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
