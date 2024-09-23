using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public static class NotificationFactory
    {
        public static INotificationStrategy CreateNotificationStrategy(string channel)
        {
            return channel switch
            {
                "email" => new EmailNotificationStrategy(),
                "sms" => new SmsNotificationStrategy(),
                "externalemail" => new ExternalEmailServiceAdapter(new ExternalEmailService()),
                _ => throw new ArgumentException("Invalid channel"),
            };
        }
    }

}
