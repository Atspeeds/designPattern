namespace ChaninOfResposibilityDP.Context
{
    public class UserWallet
    {
        public string Name { get; set; }
        public int WalletBalance{ get; set; }

        public UserWallet(string name, int walletBalance)
        {
            Name = name;
            WalletBalance = walletBalance;
        }
    }

}
