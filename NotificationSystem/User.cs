using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class User : IObserver
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ExternalEmail { get; set; }

        private readonly Dictionary<string, string> _subscriptions = new Dictionary<string, string>();

        public void Subscribe(string channel, string contactInfo)
        {
            _subscriptions[channel] = contactInfo;
        }

        public void Unsubscribe(string channel)
        {
            if (_subscriptions.ContainsKey(channel))
            {
                _subscriptions.Remove(channel);
            }
        }

        public void Update(string channel, string subject, string message)
        {
            if (_subscriptions.ContainsKey(channel))
            {
                var contactInfo = _subscriptions[channel];
                var notificationStrategy = NotificationFactory.CreateNotificationStrategy(channel);
                notificationStrategy.Send(contactInfo, subject, message);
            }
        }

        // Method to display the user's subscription information
        public void DisplaySubscriptions()
        {
            Console.WriteLine($"\nUser: {Name}");
            foreach (var subscription in _subscriptions)
            {
                Console.WriteLine($"Subscribed to {subscription.Key} with contact info: {subscription.Value}");
            }
        }
    }

}
