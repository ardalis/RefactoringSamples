using System;
using System.Linq;

namespace ClassRefactorings.ExtractInterface.Good
{
    public class Customer
    {
        public string EmailAddress { get; private set; }
    }


    public class NotificationService : INotificationService
    {
        public void EmailCheckoutNotification(string emailAddress, string message)
        {
            // send an email with the order id to the customer
        }
    }

    public interface INotificationService
    {
        void EmailCheckoutNotification(string emailAddress, string message);
    }

    public class Cart
    {
        private readonly Customer _customer;
        private INotificationService _notificationService = new NotificationService();

        public void Checkout()
        {
            // do other things
            string orderId = "";
            _notificationService.EmailCheckoutNotification(_customer.EmailAddress, orderId);
        }
    }
}