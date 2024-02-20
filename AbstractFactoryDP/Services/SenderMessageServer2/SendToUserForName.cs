using System;

namespace AbstractFactoryDP.Services.SenderMessageServer2
{
    public class SendToUserForName: ISendMessageTwo
    {
        public void SendMessage(string message, string Name)
        {
            Console.WriteLine("Message With Server2 Send For {0} Message :{1}", Name, message);
        }
    }
}
