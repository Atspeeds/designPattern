using System;

namespace SingletoneDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var web1 = WebSiteLink.GetWebSiteLink();
            var web2 = WebSiteLink.GetWebSiteLink();
            Console.WriteLine(web1 == web2);
        }
    }

}
