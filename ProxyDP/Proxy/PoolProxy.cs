using ProxyDP.Services;
using System.Collections.Generic;

namespace ProxyDP.Proxy
{
    public class PoolProxy : ISwimmingPoolService
    {
        private SwimmingPoolService _poolService;

        public List<string> GetMemberVip()
        {
            List<string> memberVip = new List<string>();

            if (_poolService == null) _poolService = new SwimmingPoolService();

            var members = _poolService.GetMemberVip();

            int num = 0;

            foreach (var member in members)
            {
                if (num < 2)
                {
                    memberVip.Add(member);
                    num++;
                }

            }

            return memberVip;
        }


    }
}
