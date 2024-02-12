using System;
using DecoratorDP.DecoratorMessage;
using DecoratorDP.RepositoryMessage;

namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SendMessage sendMessage = new SendMessage();

            LogDecorator logDecorator = new LogDecorator(sendMessage);


            logDecorator.Send("Amir Kharazi");

            Console.ReadKey();

        }
    }



}
