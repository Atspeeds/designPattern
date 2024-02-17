using FactoryMethod.FactoryService;
using FactoryMethod.Services;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPackageService packageService;
            IPackageFactoryCreator creator=new PackageFactoryCreator();

            packageService = creator.Factory(ServiceDeliveryService.PhysicalDelivery);

            packageService.SendPackage();

        }
    }
}
