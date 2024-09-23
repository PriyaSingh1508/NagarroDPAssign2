
namespace NotificationSystem
{
    public interface INotificationStrategy
    {
        void Send(string recipient, string subject, string message);
    }

}
