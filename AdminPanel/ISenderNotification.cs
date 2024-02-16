using System;
using System.Collections.Generic;

namespace AdminPanel
{
    public interface ISenderNotification
    {
        void SendToAdmins(string message,List<String> adminNames);
    }
}
