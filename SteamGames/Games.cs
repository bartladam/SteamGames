using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal class Games
    {
        public string nameGame { get; init; }
        public int priceGame { get; private set; }
        public enum Genre {Arcade, Strategy, Simulator, Fantasy, Battle}
        public Genre genre { get; init; }
        public Games(string nameGame, int priceGame, Genre genre)
        {
            this.nameGame = nameGame;
            this.priceGame = priceGame;
            this.genre = genre;
        }
    }
}
