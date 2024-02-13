using System.Collections.Generic;

namespace ProxyDP.Services
{
    public class SwimmingPoolService : ISwimmingPoolService
    {
        List<string> Members = new List<string>()
        {
            new string("Amir"),
            new string("Sina"),
            new string("Ehsan"),
            new string("Hamid")
        };

        public List<string> GetMemberVip()
        {
            return Members;
        }

    }
}
