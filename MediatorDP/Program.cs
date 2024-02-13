using System;
using MediatorDP.MediatorConector;
using MediatorDP.Services;

namespace MediatorDP
{
    public class Program
    {
        static void Main(string[] args)
        {

            var u1 = new User1();
            var u2 = new User2();

            var concreteMediator=new ConcreteMediator(u1,u2);

            u1.SetMediator(concreteMediator);
            u2.SetMediator(concreteMediator);

            u1.SendMessage(" Man User 1 Hastam ");
            u2.SendMessage(" Manam User 2 Hastam Amir ");


            Console.ReadKey();
        }
    }


}
