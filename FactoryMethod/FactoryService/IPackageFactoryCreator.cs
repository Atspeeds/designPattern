﻿using FactoryMethod.Services;

namespace FactoryMethod.FactoryService
{
    public interface IPackageFactoryCreator
    {
        IPackageService Factory(ServiceDeliveryService servicePackage);
    }
    public class PackageFactoryCreator : IPackageFactoryCreator
    {
        public IPackageService Factory(ServiceDeliveryService servicePackage)
        {
            if (servicePackage == ServiceDeliveryService.Car)
            {
                return new CarService();
            }
            else if(servicePackage == ServiceDeliveryService.Motor)
            {
                return new MotorService();
            }
            return new PhysicalDeliveryService();
        }
    }
}
