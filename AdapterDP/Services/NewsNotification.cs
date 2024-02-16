using System;

namespace AdapterDP
{
    public class NewsNotification : INotification
    {
        public void SendNotif(string message)
        {
            Console.WriteLine("Notification News Sent For Message:{0}", message);
        }
    }

}
