using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal interface IUser
    {
        string username { get; }
        string password { get; }
        void LogIn();
    }

}
