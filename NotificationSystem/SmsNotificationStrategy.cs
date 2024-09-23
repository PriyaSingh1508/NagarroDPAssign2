

namespace NotificationSystem
{
    public class SmsNotificationStrategy : INotificationStrategy
    {
        public void Send(string recipient, string subject, string message)
        {
            Console.WriteLine($"SMS sent to {recipient} with subject: {subject} and message: {message}");
        }
    }

}
