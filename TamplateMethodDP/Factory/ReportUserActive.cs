using System.Collections.Generic;
using TamplateMethodDP.Entity;

namespace TamplateMethodDP.Factory
{
    public abstract class ReportUserActive
    {
        public void TemplateMethod()
        {
            var user = GetUserList();
            var activeUser = GetUsersActive(user);
            SmsUserActive(activeUser);
        }


        protected abstract List<UserViewModel> GetUserList();
        protected abstract List<UserViewModel> GetUsersActive(List<UserViewModel> command);
        protected abstract void SmsUserActive(List<UserViewModel> command);

    }

}
