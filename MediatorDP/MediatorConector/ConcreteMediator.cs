using MediatorDP.Services;

namespace MediatorDP.MediatorConector
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteMediator(User1 user1, User2 user2) : base(user1, user2)
        {
        }

        public override void NotifyChange(string message, IChatService chatService)
        {
            if (chatService == user1)
            {
                user2.ReceiveMessage(message);
            }
            else if (chatService == user2)
            {
                user1.ReceiveMessage(message);
            }
        }
    }


}
