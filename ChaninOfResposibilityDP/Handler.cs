using ChaninOfResposibilityDP.Context;
using System.Collections.Generic;

namespace ChaninOfResposibilityDP
{
    public abstract class Handler
    {
        public abstract Handler SetHandler(Handler Successor);
        

        public virtual void GetUserWalletIsStock() { }
        public virtual void MessageToUsersStockUserWallet(List<UserWallet> command) { }
        public virtual void SendToAdmin(List<UserWallet> command) { }

    }

}
