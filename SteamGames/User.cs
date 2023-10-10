using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal class User : IUser
    {
        public string username { get; private set; }
        public string password { get; private set; }
        private Steam steam { get; init; }
        public User(string username, string password, Steam steam)
        {
            this.username = username;
            this.password = password;
            steam.AddUserToDatabase(this);
            this.steam = steam;
        }
        public void LogIn()
        {
            steam.LogIn(username, password);
        }

    }
}
