using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    /// <summary>
    /// Administrator manage platform steam
    /// </summary>
    internal class Administrator : User
    {
        /// <summary>
        /// Administrator has to access into platform steam for manage it
        /// </summary>
        private Steam steam { get; init; }
        public Administrator(string username, string password, Steam steam): base(username, password, steam)
        {
            this.steam = steam;
        }

    }
}
