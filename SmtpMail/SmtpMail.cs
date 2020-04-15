using System;
using System.Net;
using System.Net.Mail;


namespace SmtpMail
{
    class SendMail
    {
        public static void Main(string[] args)
        {
            try
            {          
                      SmtpClient client = new SmtpClient("smtp.gmail.com",25);
                      string fromMail;
                      string toMail="karan1198kumar@gmail.com";
                      Console.WriteLine("Enter the  email Id ");
                      fromMail=Console.ReadLine();
                      //Console.WriteLine(fromMail);
                      client.EnableSsl =true;
                      client.Timeout = 100000;
                      client.DeliveryMethod= SmtpDeliveryMethod.Network;
                      client.UseDefaultCredentials=false;
                      client.Credentials = new NetworkCredential(fromMail,"Karan12345@");
                      MailMessage message=new MailMessage(fromMail,toMail);
                      message.Subject="mail check";
                      message.Body="First mail to check the process";
                      client.Send(message);

                
                Console.WriteLine("email was sent successfully!");
            }
            catch (Exception SendingFailed)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(SendingFailed.Message);
            }
        }
    }
}