using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class BlackJack : Game, IWalkAway
    {
        public BlackJackDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new BlackJackDealer();
            foreach (Player player in Players)
            {

            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Black Jack Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
