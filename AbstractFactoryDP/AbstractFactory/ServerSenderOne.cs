using AbstractFactoryDP.Services.SenderMessageServer1;
using AbstractFactoryDP.Services.SenderMessageServer2;

namespace AbstractFactoryDP.AbstractFactory
{
    public class ServerSenderOne : IAbstractFactory
    {
        public ISendMessageServerOne ServerMessage1()
        {
            return new SendMessageForAdmin();
        }

        public ISendMessageTwo ServerMessage2()
        {
            return new SendToAdminForName();
        }
    }

}
