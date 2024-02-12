using System;

namespace DecoratorDP.RepositoryMessage
{
    public class SendMessage : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine("SendMessage.Send With Message: {0}", message);
        }
    }



}
