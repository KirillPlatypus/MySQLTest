using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Management;
using System.Runtime.Remoting.Channels;
using Google.Apis.Auth.OAuth2;
using MailKit.Security;
using System.Security.Cryptography.X509Certificates;

namespace MySQL_Test
{
    class Email
    {
        private static string login;
        private static string password;

        MailAddress sender;
        MailAddress addressee;
        MailMessage emailMessege;

        public Email(string logins, string passwords)
        {
            login = logins;
            password = passwords;

            sender = new MailAddress(login, "username");
            addressee = new MailAddress(login);
        }

        public async Task Send(string messege, string subject)
        {
            var certificate = new X509Certificate2(@"C:\path\to\certificate.p12", "password", X509KeyStorageFlags.Exportable);
            var credential = new ServiceAccountCredential(new ServiceAccountCredential
                .Initializer("your-developer-id@developer.gserviceaccount.com")
            {
                Scopes = new[] { "https://mail.google.com/" },
                User = "username@gmail.com"
            }.FromCertificate(certificate));

            //bool result = await credential.RequestAccessTokenAsync(cancel.Token);

            //emailMessege = new MailMessage(sender, addressee);

            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.gmail.com", 587);

            //    var oauth2 = new SaslMechanismOAuth2("mymail@gmail.com", credential.Token.AccessToken);
            //    client.Authenticate(oauth2);

            //    client.Send(emailMessege);
            //    client.Disconnect(true);
            //}
        }
    }
}
