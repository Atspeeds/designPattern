using AbstractFactoryDP.Services.SenderMessageServer1;
using AbstractFactoryDP.Services.SenderMessageServer2;

namespace AbstractFactoryDP.AbstractFactory
{
    public class ServerSenderTwo : IAbstractFactory
    {
        public ISendMessageServerOne ServerMessage1()
        {
            return new SendMessageForUser();
        }

        public ISendMessageTwo ServerMessage2()
        {
            return new SendToUserForName();
        }

    }

}
