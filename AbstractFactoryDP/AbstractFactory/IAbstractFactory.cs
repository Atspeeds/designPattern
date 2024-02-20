using AbstractFactoryDP.Services.SenderMessageServer1;
using AbstractFactoryDP.Services.SenderMessageServer2;

namespace AbstractFactoryDP.AbstractFactory
{
    public interface IAbstractFactory
    {
        ISendMessageServerOne ServerMessage1();
        ISendMessageTwo ServerMessage2();
    }

}
