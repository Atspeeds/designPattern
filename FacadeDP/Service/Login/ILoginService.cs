using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.Service.Login
{
    public interface ILoginService
    {
        bool Exists(string command);
        void Login(string command);
    }
}
