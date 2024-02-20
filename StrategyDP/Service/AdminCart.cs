using System.Collections.Generic;

namespace StrategyDP.Service
{
    public class AdminCart : IUnpaid
    {
        public List<string> GetUnpaids(string role)
        {
            return Products.GetProduct();
        }
    }


}
