using FacadeDP.FacadeUser;
using FacadeDP.Service.Register;
using System;

namespace FacadeDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserFacadeService ServiceUser=new UserFacadeService();

            ServiceUser.registerService.RegisterUser("AmirKharazi");

            ServiceUser.loginService.Login("AmirKharazi");



            Console.ReadKey();
        }
    }
}
