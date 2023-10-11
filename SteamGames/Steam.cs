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

        }
    }
}
