using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TAGO_Servicios.Utilitarios
{
    public static class SenderSMS
    {

        private static string twilio_cuenta = ConfigurationManager.AppSettings["twilio_account_id"];
        private static string twilio_token = ConfigurationManager.AppSettings["twilio_token"];


        public static void EnviarSMS(string numero, string mensaje)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            string accountSid = twilio_cuenta;
            string authToken = twilio_token;
            TwilioClient.Init(accountSid, authToken);
            
            //string mensaje = Console.ReadLine();
            //var to = new PhoneNumber("+51996971734");
            var to = new PhoneNumber(string.Format("+51{0}",numero));
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("(281) 612-5717 "),
                body: mensaje);

            Console.WriteLine(message.Sid);
            //mensaje = Console.ReadLine();
        }

    }
}