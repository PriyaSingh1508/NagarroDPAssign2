namespace NotificationSystem
{
    public class NotificationFacade
    {
        private readonly NotificationService _notificationService;

        public NotificationFacade()
        {
            _notificationService = NotificationService.GetInstance();
        }

        public void SubscribeUser(User user, string channel, string contactInfo)
        {
            user.Subscribe(channel, contactInfo);
            _notificationService.Subscribe(user, channel);
        }

        public void UnsubscribeUser(User user, string channel)
        {
            user.Unsubscribe(channel);
            _notificationService.Unsubscribe(user, channel);
        }

        public void SendNotification(string channel, string subject, string message)
        {
            _notificationService.NotifyObservers(channel, subject, message);
        }
    }
}
