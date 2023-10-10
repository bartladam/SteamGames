using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal class Steam
    {
        private List<User> users { get; set; }
        public string loged { get; private set; }
        public Steam()
        {
            users = new List<User>();
        }
        public void LogIn(string username, string password)
        {
            var user = from i in users
                       where (i.username.Equals(username) && i.password.Equals(password))
                       select new { Loged = "Loged: " + i.username };
            foreach (var item in user)
            {
                loged = item.Loged;
            }
        }
        public void AddUserToDatabase(User user)
        {
            users.Add(user);
        }
    }
}
