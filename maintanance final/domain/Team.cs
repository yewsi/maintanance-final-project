using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.domain
{
    class Team
    {
        private IList<Player> players;
        
        public Team()
        {
            players = new List<Player>();
        }

        public void AddPlayerToTeam(Player player)
        {
            players.Add(player);
        }

        public void TeamWon()
        {
            foreach (Player player in players)
            {
                player.IncrementWins();
            }
        }

        public void TeamLost()
        {
            foreach (Player player in players)
            {
                player.IncrementLosses();
            }
        }

        public override string ToString()
        {
            string result = "";

            foreach(Player player in players)
            {
                result += player.Name + "\n";
            }
            return result;
        }

    }
}
