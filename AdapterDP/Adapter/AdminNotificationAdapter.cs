using AdminPanel;
using System.Collections.Generic;

namespace AdapterDP.Adapter
{
    public class AdminNotificationAdapter : INotification
    {
        private ISenderNotification _senderNotification;
        public AdminNotificationAdapter(ISenderNotification senderNotification)
        {
            _senderNotification = senderNotification;
        }

        public void SendNotif(string message)
        {
            var context = new List<string>()
            {
                new string("Amir"),
                new string("Sina"),
                new string("Ahmad"),
                new string("Abbas"),
                new string("Hamid"),
            };
            _senderNotification.SendToAdmins(message, context);
        }

    }

}
