using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    /// <summary>
    /// Platform where we can play games, buy games, share experience with community etc
    /// </summary>
    internal class Steam
    {
        /// <summary>
        /// Steam has database for saving all registred users
        /// </summary>
        private List<User> users { get; set; }
        /// <summary>
        /// Shows logged user
        /// </summary>
        public string logged { get; private set; }
        /// <summary>
        /// Personal library of the currently logged in user
        /// </summary>
        public Library library { get; private set; }
        /// <summary>
        /// Steam offer many games, which are all saved in List
        /// </summary>
        public List<Games> listGames { get; private set; }
        public Steam(params Games[] games)
        {
            users = new List<User>();
            listGames = new List<Games>(games);
        }
        /// <summary>
        /// Before the user manipulating with steam, user has to successfully login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void LogIn(string username, string password)
        {
            var user = from i in users
                       where (i.username.Equals(username) && i.password.Equals(password))
                       select new { Loged = "Loged: " + i.username };
            foreach (var item in user)
            {
                logged = item.Loged;
            }
            do
            {
                Console.Clear();
                if(logged is not "")
                {
                    Console.WriteLine(@"Welcome in STEAM
1 - Buy game
2 - Your library");

                    switch(Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Console.WriteLine();
                            foreach (Games item in listGames)
                            {
                                Console.WriteLine("{0} ({1} Kč)", item.nameGame, item.priceGame);
                            }
                            Console.Write("\nName game: ");
                            string selectedGames = Console.ReadLine();
                            BuyGame(selectedGames);
                            break;
                        case '2':
                            Console.WriteLine();
                            foreach (Games item in library.games)
                            {
                                Console.WriteLine("{0}", item.nameGame);
                            }
                            break;
                    }
                }
                Console.ReadKey();
            } while (true);
        }
        /// <summary>
        /// First step before login is registration each new user
        /// </summary>
        /// <param name="user"></param>
        public void AddUserToDatabase(User user)
        {
            users.Add(user);
            library = new Library();
        }
        /// <summary>
        /// User can buy new game and add to his library for future playing 
        /// </summary>
        /// <param name="nameGame"></param>
        private void BuyGame(string nameGame)
        {
            foreach (Games item in listGames)
            {
                if(item.nameGame.Equals(nameGame))
                {
                    if(item.priceGame > 0)
                    {
                        PaymentGate p = new PaymentGate();
                        if (p.Pay(item.priceGame))
                            DownloadGame(item);
                    }
                    else
                    {
                        DownloadGame(item);
                    }
                }
            }
        }
        /// <summary>
        ///If is game free or payment was successfully, the user get option to download game
        /// </summary>
        /// <param name="games"></param>
        private void DownloadGame(Games games)
        {
            library.AddToLibrary(games);
        }
    }
}
