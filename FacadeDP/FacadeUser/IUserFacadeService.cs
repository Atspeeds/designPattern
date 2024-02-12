using FacadeDP.Service.Login;
using FacadeDP.Service.Register;

namespace FacadeDP.FacadeUser
{
    public interface IUserFacadeService
    {
        public ILoginService loginService { get; }
        public IRegisterService registerService { get; }

    }
}
