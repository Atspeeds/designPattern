using FlyweightDP.Factory;
using FlyweightDP.Services;

namespace FlyweightDP
{
    internal class Program
    {
        //آبجکت اول ساخته میشه و دیگه برای آبجکت بعدی فقط وضعیتش تغییر میکنه
        static void Main(string[] args)
        {
            SoldierFactory factory = new SoldierFactory();

            // Create a first-class soldier
            ISoldier firstClassSoldier = factory.GetSoldier("FirstClass");
            firstClassSoldier.Location(10, 11);

            // Create a second-rank soldier
            ISoldier secondRankSoldier = factory.GetSoldier("SecondRank");
            secondRankSoldier.Location(20, 30);

            // Reusing the first-class soldier
            ISoldier firstClassSoldier2 = factory.GetSoldier("FirstClass");
            firstClassSoldier2.Location(15, 25);
        }
    }



}
