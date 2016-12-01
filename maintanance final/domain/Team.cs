using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.domain
{
    //! Class to represent a team 
    /*!
      \author Adam Boghe
      \date 2016
      
    */
    class Team
    {
        private IList<Player> players;

        //! Team class constructor.
        public Team()
        {
            players = new List<Player>();
        }

        //! Method that adds Player to this team
        public void AddPlayerToTeam(Player player)
        {
            players.Add(player);
        }

        //! Method that increments this team's players their win score 
        public void TeamWon()
        {
            foreach (Player player in players)
            {
                player.IncrementWins();
            }
        }

        //! Method that increments this team's players their loss score
        public void TeamLost()
        {
            foreach (Player player in players)
            {
                player.IncrementLosses();
            }
        }

        //! Method that prints the object's data
        /*!
          \return All the names in the team, each on their own line
        */
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
