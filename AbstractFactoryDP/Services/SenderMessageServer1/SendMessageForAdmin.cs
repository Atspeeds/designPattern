using System;

namespace AbstractFactoryDP.Services.SenderMessageServer1
{
    public class SendMessageForAdmin : ISendMessageServerOne
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Admin : Message With Server1 Send Message: {0}", message);
        }
    }
}
