

namespace NotificationSystem
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void Send(string recipient, string subject, string message)
        {
            Console.WriteLine($"Email sent to {recipient} with subject: {subject} and message: {message}");
        }
    }

}
