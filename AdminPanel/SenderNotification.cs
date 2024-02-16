using System;
using System.Collections.Generic;

namespace AdminPanel
{
    public class SenderNotification : ISenderNotification
    {
        public void SendToAdmins(string message, List<string> adminNames)
        {
            foreach (var adminName in adminNames)
            {
                Console.WriteLine("Notification  with Message {0} Sent To : {1}",message,adminName);
            }
        }

    }
}
