using FactoryMethod.Services;

namespace FactoryMethod.FactoryService
{
    public interface IPackageFactoryCreator
    {
        IPackageService Factory(ServiceDeliveryService servicePackage);
    }
}
