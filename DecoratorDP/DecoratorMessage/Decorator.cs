using DecoratorDP.RepositoryMessage;

namespace DecoratorDP.DecoratorMessage
{
    public abstract class Decorator : ISendMessage
    {
        private ISendMessage _sendMessage;

        protected Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public virtual void Send(string message)
        {
            _sendMessage.Send(message);
        }


    }



}
