using ChaninOfResposibilityDP.Context;
using System;
using System.Collections.Generic;

namespace ChaninOfResposibilityDP.Concreat
{
    public class MessageServiceWallet : Handler
    {
        protected Handler _Successor;

        public override void MessageToUsersStockUserWallet(List<UserWallet> command)
        {
            foreach (var item in command)
            {
                Console.WriteLine($"{item.Name} your Wallet Succeded With Price:{item.WalletBalance}");
            }
            _Successor.SendToAdmin(command);
        }
        public override Handler SetHandler(Handler Successor)
        {
            _Successor = Successor;
            return _Successor;
        }
    }

}
