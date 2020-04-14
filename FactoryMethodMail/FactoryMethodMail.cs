using System.Net.Mail;
using System.Net;
using System;

namespace FactoryMethodMail
{
    abstract class sendMail
    {     
        public abstract String ServerType { get;}
        public abstract void sendTheMail();
    }
 
    
    class gmailServer : sendMail
    {    
        private String _ServerType;

        public gmailServer(string serverType)
        {
            _ServerType=serverType;
        }
         public override string ServerType  
        {  
            get { return _ServerType; }
              
        }  

        public override void sendTheMail()
       {

           try
            {          
                      SmtpClient client = new SmtpClient(ServerType,25);
                      string fromMail;
                      string toMail;
                      Console.WriteLine("Enter the  from mail Id ");

                      fromMail=Console.ReadLine();
                      Console.WriteLine("Enter the to Mail Id");
                      toMail=Console.ReadLine();
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
    
    /*class gmailServer : sendMail
    {    
        private String _ServerType;

        public gmailServer(string serverType)
        {
            _ServerType=serverType;
        }
         public override string ServerType  
        {  
            get { return _ServerType; }
              
        }  

        public override void sendTheMail()
       {

           try
            {          
                      SmtpClient client = new SmtpClient(ServerType,25);
                      string fromMail;
                      string toMail;
                      Console.WriteLine("Enter the  from mail Id ");

                      fromMail=Console.ReadLine();
                      Console.WriteLine("Enter the to Mail Id");
                      toMail=Console.ReadLine();
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
               
               
    }*/
    
    abstract class serverFactory{
     public abstract sendMail sendMailToDestination();

    }


    class gmailFactory : serverFactory
    {

         private string _ServerType;

         public gmailFactory(string serverType)
         {
                 _ServerType=serverType;

         }

         public override sendMail sendMailToDestination(){
            
             return new gmailServer(_ServerType);
         }

    }


    public class client
    {

           static void Main()
           {

               serverFactory sFactory=null;

               Console.WriteLine("Enter the servert type you want to use");
               string userOption=Console.ReadLine();

               switch(userOption)
               {
                  case "gmail":
                                 sFactory = new gmailFactory("smtp.gmail.com");
                                 
                                 break;
                  default : Console.WriteLine("Not A valid mailServer");
                            break;               


               }
               sendMail send = sFactory.sendMailToDestination();
               send.sendTheMail();



           }

    }
    
}
