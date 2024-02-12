using System;
using DecoratorDP.RepositoryMessage;

namespace DecoratorDP.DecoratorMessage
{
    public class LogDecorator : Decorator
    {
        public LogDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            LogMessage(message);
        }


        private void LogMessage(string message)
        {
            Console.WriteLine("LogDecorator LogMessage Log Complate: {0}", message);
        }

    }



}
