using ChaninOfResposibilityDP.Context;
using System;
using System.Collections.Generic;

namespace ChaninOfResposibilityDP.Concreat
{
    public class AdminService : Handler
    {
        protected Handler _Successor;
        public override void SendToAdmin(List<UserWallet> command)
        {
            foreach (var item in command)
            {
                Console.WriteLine($"Report To Admin For Wallet:{item.Name}");
            }
        }
        public override Handler SetHandler(Handler Successor)
        {
            _Successor = Successor;
            return _Successor;
        }
    }

}
