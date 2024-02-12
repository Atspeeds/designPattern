using System;

namespace FacadeDP.Service.Register
{
    public class RegisterService : IRegisterService
    {
        public void RegisterUser(string command)
        {
            if (!string.IsNullOrEmpty(command))
            {
                Console.WriteLine("RegisterService Succede");
            }
            else
            {
                Console.WriteLine("RegisterService Faild");
            }
            
        }
    }

}
