using System;
using System.Collections.Generic;

namespace StrategyDP.Service
{
    public class UserCartService : IUnpaid
    {
        public List<string> GetUnpaids(string role)
        {
            var productList = new List<string>();

            if (role != "User")
                throw new Exception();

            string idUser = "1234";//Context.User.id
            //var productUserUnpaid = cart.where(x => x.id == idUser && x.paid = false);
            int num = 0;

            foreach (var item in Products.GetProduct())
            {
                if (num <= 3)
                {
                    productList.Add(item);
                    num++;
                }

            }

            return productList;

        }
    }


}
