using System;
using System.Collections.Generic;
using System.Linq;
using TamplateMethodDP.Context;
using TamplateMethodDP.Entity;

namespace TamplateMethodDP.Factory.Concreate
{
    public class UserService : ReportUserActive
    {
        protected override List<UserViewModel> GetUserList()
        {
            List<UserViewModel> userViewModels = new List<UserViewModel>();
            var users = new DBContext();

            foreach (var item in users)
            {

                userViewModels.Add((UserViewModel)item);

            }
            return userViewModels;
        }

        protected override List<UserViewModel> GetUsersActive(List<UserViewModel> command)
        {
            List<UserViewModel> userViewModels = new List<UserViewModel>();
            var activeUsers = command.Where(x => x.IsActive).ToList();
            foreach (var user in activeUsers)
            {
                userViewModels.Add(user);
            }
            return userViewModels;
        }

        protected override void SmsUserActive(List<UserViewModel> command)
        {
            foreach (var item in command)
            {
                Console.WriteLine($"{item.Name} yourUser Active Plase To MySite Buyer");
            }

        }

    }

}
