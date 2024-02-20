using System;
using StrategyDP.Service;

namespace StrategyDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnpaid unpaid;
            unpaid = new UserCartService();

            var context = new ContextCart(unpaid);
           var listun= context.ContextUnpaid("User");

            foreach (var item in listun)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\n \n");
            //=============================================================
            unpaid = new AdminCart();
            var contextAdmin = new ContextCart(unpaid);
            var listunAdmin = contextAdmin.ContextUnpaid("Admin");

            foreach (var item in listunAdmin)
            {
                Console.WriteLine(item);
            }
        }
    }


}
