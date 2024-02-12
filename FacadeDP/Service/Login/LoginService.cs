using System;

namespace FacadeDP.Service.Login
{
    public class LoginService : ILoginService
    {
        public bool Exists(string command)
        {
           if(!string.IsNullOrEmpty(command)) return true;
           return false;
        }

        public void Login(string command)
        {
            if(Exists(command))
            {
                Console.WriteLine("Login Succeded");
            }
            else
            {
                Console.WriteLine("Login Faild");
            }
            
        }
    }
}
