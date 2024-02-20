using System.Collections.Generic;

namespace StrategyDP.Service
{
    public interface IUnpaid
    {
        List<string> GetUnpaids(string role);
    }


}
