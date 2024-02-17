namespace FactoryMethod.Services
{
    public class CarService : IPackageService
    {
        public void SendPackage()
        {
            System.Console.WriteLine("Package Send With Car...");
        }
    }



}
