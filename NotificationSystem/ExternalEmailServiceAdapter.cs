namespace NotificationSystem
{
    // Adapter for the third-party email service
    public class ExternalEmailServiceAdapter : INotificationStrategy
    {
        private readonly ExternalEmailService _externalEmailService;

        public ExternalEmailServiceAdapter(ExternalEmailService externalEmailService)
        {
            _externalEmailService = externalEmailService;
        }

        public void Send(string recipient, string subject, string message)
        {
            _externalEmailService.SendExternalEmail(recipient, subject, message);
        }
    }

}
