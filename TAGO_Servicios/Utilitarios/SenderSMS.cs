using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TAGO_Servicios.Utilitarios
{
    public static class SenderSMS
    {

        public static void EnviarSMS(string mensaje)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "AC35ae9f6e6acdb736a2403039f39c05e5";
            const string authToken = "beb6da659f9abc64cb1101ac0e6e3d03";
            TwilioClient.Init(accountSid, authToken);

            Console.WriteLine("Escribe tu mensaje: ");
            //string mensaje = Console.ReadLine();
            //var to = new PhoneNumber("+51996971734");
            var to = new PhoneNumber("+51990015452");
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("(281) 612-5717 "),
                body: mensaje);

            Console.WriteLine(message.Sid);
            mensaje = Console.ReadLine();
        }

    }
}