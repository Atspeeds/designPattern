using System;
using System.Collections.Generic;
using FlyweightDP.Services;

namespace FlyweightDP.Factory
{
    public class SoldierFactory
    {
        private Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();

        public ISoldier GetSoldier(string degree)
        {
            if (!soldiers.ContainsKey(degree))
            {
                switch (degree)
                {
                    case "FirstClass":
                        soldiers[degree] = new FirstClassSoldier();
                        break;
                    case "SecondRank":
                        soldiers[degree] = new SecondRankSoldier();
                        break;
                    default:
                        throw new ArgumentException("Invalid soldier degree.");
                }
            }

            return soldiers[degree];
        }
    }



}
