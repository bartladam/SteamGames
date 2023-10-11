using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    /// <summary>
    /// Steam is offering games, library is saving this games
    /// </summary>
    internal class Games
    {
        /// <summary>
        /// User finding games via name 
        /// </summary>
        public string nameGame { get; init; }
        /// <summary>
        /// If game not bought yet, the product still have price
        /// </summary>
        public int priceGame { get; private set; }
        /// <summary>
        /// Genre of game is important for user, who don't know this game and is deciding about buying it
        /// </summary>
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
