using ChaninOfResposibilityDP.Context;
using System.Collections.Generic;

namespace ChaninOfResposibilityDP.Concreat
{
    public class WalletChecker : Handler
    {
        protected Handler _Successor;
        public override void GetUserWalletIsStock()
        {
            List<UserWallet> userWallets = new List<UserWallet>();
            var wallets = new DBContext();

            foreach (var item in wallets)
            {
                var wallert = (UserWallet)item;
                if (wallert.WalletBalance >= 100)
                {
                    userWallets.Add(wallert);
                }
            }
            if (userWallets != null)
                _Successor.MessageToUsersStockUserWallet(userWallets);

        }

        public override Handler SetHandler(Handler Successor)
        {
            _Successor = Successor;
            return _Successor;
        }
    }

}
