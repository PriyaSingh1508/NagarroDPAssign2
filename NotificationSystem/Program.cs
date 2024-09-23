namespace NotificationSystem
{
    public class Program
    {
        static NotificationFacade notificationFacade = new NotificationFacade();
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            // Setup users and subscribe them to channels
            SetupUsers();
            // Display all users and their subscription info
            DisplayUserSubscriptions();

            // Send notification via email, sms, and external email
            notificationFacade.SendNotification("email", "Order Shipped", "Your order has been shipped!");
            notificationFacade.SendNotification("sms", "Promotion Alert", "50% off on all items!");
            notificationFacade.SendNotification("externalemail", "New Features", "Check out our new features in the app!");
        }

        static void SetupUsers()
        {
            
            var user1 = new User
            {
                Name = "user1",
                Email = "user1@gmail.com",
                PhoneNumber = "8909863456",
                ExternalEmail = "userpersonal@gmail.com"
            };

            // Use Façade to subscribe user to channels
            notificationFacade.SubscribeUser(user1, "email", user1.Email);
            notificationFacade.SubscribeUser(user1, "sms", user1.PhoneNumber);
            notificationFacade.SubscribeUser(user1, "externalemail", user1.ExternalEmail);
            //notificationFacade.UnsubscribeUser(user1, "sms");

            // Add user to the list
            users.Add(user1);
        }
        static void DisplayUserSubscriptions()
        {
            Console.WriteLine("\nDisplaying all users and their subscriptions:");
            foreach (var user in users)
            {
                user.DisplaySubscriptions();  // Display each user's subscription info
            }
        }
    }

}
