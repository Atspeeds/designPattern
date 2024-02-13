using System;
using ProxyDP.Proxy;
using ProxyDP.Services;

namespace ProxyDP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ISwimmingPoolService poolVip = new PoolProxy();

            foreach (var item in poolVip.GetMemberVip())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
