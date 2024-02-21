using System.Collections;
using System.Collections.Generic;
using TamplateMethodDP.Entity;

namespace TamplateMethodDP.Context
{
    public class DBContext : IEnumerable
    {
        private List<UserViewModel> Users = new List<UserViewModel>()
        {
            new UserViewModel("Amir",true),
           new UserViewModel("Hossain",false),
            new UserViewModel("Sina",true),
             new UserViewModel("Ehsan",true),
             new UserViewModel("Mohammad",false),
             new UserViewModel("Abbas",true),
             new UserViewModel("Kamyar",false),
             new UserViewModel("Hamid",true),
             new UserViewModel("Mina",false),
             new UserViewModel("Poya",false),
             new UserViewModel("Mohsen",true),
        };
        public IEnumerator GetEnumerator()
        {
            return Users.GetEnumerator();
        }
    }

}
