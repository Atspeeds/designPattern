using System;

namespace AdapterDP
{
    public class DiscountsNotification : INotification
    {
        public void SendNotif(string message)
        {
            Console.WriteLine("Notification Discounts Sent For Message:{0}",message);
        }
    }

}
