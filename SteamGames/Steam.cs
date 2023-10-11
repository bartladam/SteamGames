using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal class Steam
    {
        private List<User> users { get; set; }
        public string loged { get; private set; }
        public Library library { get; private set; }
        public List<Games> listGames { get; private set; }
        public Steam(params Games[] games)
        {
            users = new List<User>();
            listGames = new List<Games>(games);
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
            do
            {
                Console.Clear();
                if(loged is not "")
                {
                    Console.WriteLine(@"
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
                            Console.Write("Name game: ");
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
        public void AddUserToDatabase(User user)
        {
            users.Add(user);
            library = new Library();
        }
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
        private void DownloadGame(Games games)
        {
            library.AddToLibrary(games);
        }
    }
}
