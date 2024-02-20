using System;

namespace AbstractFactoryDP.Services.SenderMessageServer2
{
    public class SendToAdminForName : ISendMessageTwo
    {
        public void SendMessage(string message, string Name)
        {
            Console.WriteLine("Admin : Message With Server2 Send For {0} Message :{1}",Name,message);
        }
    }
}
