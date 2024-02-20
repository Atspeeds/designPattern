using AbstractFactoryDP.AbstractFactory;
using System;

namespace AbstractFactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory abstractFactory = new ServerSenderOne();
            var s1 = abstractFactory.ServerMessage1();
            var s2= abstractFactory.ServerMessage2();

            s1.SendMessage("Hello");

            s2.SendMessage("hellow", "Amir");
            
        }
    }
}
