namespace NotificationSystem
{
    // A third-party email service
    public class ExternalEmailService
    {
        public void SendExternalEmail(string recipient, string subject, string message)
        {
            Console.WriteLine($"External Email sent to {recipient} with subject: {subject} and message: {message}");
        }
    }

}
