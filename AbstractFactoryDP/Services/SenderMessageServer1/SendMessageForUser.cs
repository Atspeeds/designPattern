using System;

namespace AbstractFactoryDP.Services.SenderMessageServer1
{
    public class SendMessageForUser : ISendMessageServerOne
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Message With Server1 Send Message: {0}", message);
        }
    }
}
