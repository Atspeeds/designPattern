using MediatorDP.Services;

namespace MediatorDP.MediatorConector
{
    public abstract class Mediator
    {
        protected User1 user1;
        protected User2 user2;

        protected Mediator(User1 user1, User2 user2)
        {
            this.user1 = user1;
            this.user2 = user2;
        }

        public abstract void NotifyChange(string message, IChatService chatService);

    }


}
