using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    /// <summary>
    /// User is manipulating with steam (login, buying games, playing games etc)
    /// </summary>
    internal class User : IUser
    {
        /// <summary>
        /// Username is important for login user into steam games
        /// </summary>
        public string username { get; private set; }
        /// <summary>
        /// Password is key to login into steam games
        /// </summary>
        public string password { get; private set; }
        /// <summary>
        /// Platform where we have our bought games and games not yet bought. 
        /// </summary>
        private Steam steam { get; init; }
        public User(string username, string password, Steam steam)
        {
            this.username = username;
            this.password = password;
            steam.AddUserToDatabase(this);
            this.steam = steam;
        }
        /// <summary>
        /// If we want use STEAM platform for playing games in our library, first we have to login
        /// </summary>
        public void LogIn()
        {
            steam.LogIn(username, password);
        }

    }
}
