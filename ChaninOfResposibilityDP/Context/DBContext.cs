using System.Collections;
using System.Collections.Generic;

namespace ChaninOfResposibilityDP.Context
{

    public class DBContext : IEnumerable
    {
        private List<UserWallet> Users = new List<UserWallet>()
        {
            new UserWallet("Amir",50),
           new UserWallet("Hossain",100),
            new UserWallet("Sina",10),
             new UserWallet("Ehsan",23),
             new UserWallet("Mohammad",90),
             new UserWallet("Abbas",13),
             new UserWallet("Kamyar",800),
             new UserWallet("Hamid",650),
             new UserWallet("Mina",120),
             new UserWallet("Poya",70),
             new UserWallet("Mohsen",22),
        };
        public IEnumerator GetEnumerator()
        {
            return Users.GetEnumerator();
        }
    }

}
