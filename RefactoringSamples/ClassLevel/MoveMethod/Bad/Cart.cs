using System;
using System.Linq;

namespace ClassRefactorings.MoveMethod.Bad
{
    public class Customer
    {
        public string EmailAddress { get; private set; }
    }

    public class Cart
    {
        private readonly Customer _customer;

        public void Checkout()
        {
            // do other things
            string orderId = "";
            EmailCheckoutNotification(_customer.EmailAddress, orderId);
        }

        private void EmailCheckoutNotification(string emailAddress, string orderId)
        {
            // send an email with the order id to the customer
        }
    }
}