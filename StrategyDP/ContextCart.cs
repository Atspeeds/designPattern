using System.Collections.Generic;
using StrategyDP.Service;

namespace StrategyDP
{
    public class ContextCart
    {
        private IUnpaid _unpaid;

        public ContextCart(IUnpaid unpaid)
        {
            _unpaid = unpaid;
        }
        public List<string> ContextUnpaid(string role)
        {
           return _unpaid.GetUnpaids(role);
        }

    }


}
