using FacadeDP.Service.Login;
using FacadeDP.Service.Register;

namespace FacadeDP.FacadeUser
{
    public class UserFacadeService : IUserFacadeService
    {
        private ILoginService _loginService;
        private IRegisterService _registerService;


        public ILoginService loginService 
        {
            get
            {
                return _loginService ?? (_loginService = new LoginService());
            }
        }

        public IRegisterService registerService 
        {
            get
            {
                return _registerService ?? (_registerService = new RegisterService());
            } 
        }


    }
}
