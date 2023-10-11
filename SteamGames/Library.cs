using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal class Library
    {
        public List<Games> games { get; private set; }
        public Library()
        {
            games = new List<Games>();
        }
        public void AddToLibrary(Games game)
        {
            this.games.Add(game);
        }
    }
}
