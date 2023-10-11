using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamGames
{
    /// <summary>
    /// Buying games open payment gate to pay for selected game
    /// </summary>
    internal class PaymentGate
    {
        /// <summary>
        /// User have to pay for selected game which is not free
        /// </summary>
        /// <param name="priceGame"></param>
        /// <returns></returns>
        public bool Pay(int priceGame)
        {
            int result = 0;
            do
            {
                Console.Write("Entry money: ");
                while(!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Entry money: ");
                }
            } while (result < priceGame);
            return true;
        }
    }
}
