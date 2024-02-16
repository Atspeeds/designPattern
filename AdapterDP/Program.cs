using AdapterDP.Adapter;
using AdminPanel;
using System;

namespace AdapterDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adminNotification = new SenderNotification();


            INotification notification = new NewsNotification();
            notification.SendNotif("Amir Welcome To WebSite");

            notification = new DiscountsNotification();
            notification.SendNotif("Amir Discount News For You in Website");

            notification = new AdminNotificationAdapter(adminNotification);
            notification.SendNotif("Your Admin");

        }
    }

}
