using MediatorDP.MediatorConector;

namespace MediatorDP.Services
{
    public abstract class IChatService
    {
        protected Mediator _mediator;
        public abstract string SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }


}
