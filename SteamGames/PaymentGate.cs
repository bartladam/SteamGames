using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    internal class PaymentGate
    {
        public bool Pay(int priceGame)
        {
            int result = 0;
            do
            {
                Console.WriteLine("Entry money:");
                while(!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Entry money:");
                }
            } while (result >= priceGame);
            return true;
        }
    }
}
