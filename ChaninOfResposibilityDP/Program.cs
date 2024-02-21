using ChaninOfResposibilityDP.Concreat;
using System;

namespace ChaninOfResposibilityDP
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var walletChecker=new WalletChecker();
            var messageSenderToUser = new MessageServiceWallet();
            var adminReport = new AdminService();

            walletChecker
                .SetHandler(messageSenderToUser).SetHandler(adminReport);
           

            walletChecker.GetUserWalletIsStock();


            Console.ReadKey();
        }
    }

}
