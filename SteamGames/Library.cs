using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    /// <summary>
    /// Personal library each user with owned games
    /// </summary>
    internal class Library
    {
        /// <summary>
        /// Bought games are saved in library
        /// </summary>
        public HashSet<Games> games { get; private set; }
        public Library()
        {
            games = new HashSet<Games>();
        }
        /// <summary>
        /// Adds new game title to user library
        /// </summary>
        /// <param name="game"></param>
        public void AddToLibrary(Games game)
        {
            this.games.Add(game);
        }
    }
}
