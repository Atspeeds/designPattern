using System;

namespace FactoryMethod.Services
{
    public class PhysicalDeliveryService : IPackageService
    {
        public void SendPackage()
        {
            Console.WriteLine("PhysicalDelivery Done...");
        }
    }


}
