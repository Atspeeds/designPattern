using TamplateMethodDP.Factory.Concreate;

namespace TamplateMethodDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceUsers = new Clint(new UserService());

            serviceUsers.RunUserReport();

        }
    }

}
