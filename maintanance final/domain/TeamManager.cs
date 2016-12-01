using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.domain
{
    //! Class to manage teams and players
    /*!
      \author Adam Boghe
      \date 2016
      
    */
    class TeamManager
    {
        IList<Player> players;
        IList<Team> teams;

        //! TeamManager class constructor.
        public TeamManager()
        {
            players = new List<Player>();
            teams = new List<Team>();
        }

        //! Method that creates teams and divide the players in them
        /*!
         \parameter number of teams to be created 
        */
        public void CreateTeams(int numberOfTeams)
        {
            teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                teams.Add(new Team());
            }

            this.ShufflePlayers();

            int spelersCount = 0;
            while (spelersCount < players.Count) {
                for (int i = 0; i < teams.Count; i++)
                {
                    if (spelersCount<players.Count)
                        teams.ElementAt(i).AddPlayerToTeam(players[spelersCount]);

                    spelersCount++;
                }
            }

        }

        private void ShufflePlayers()
        {
            Random rng = new Random();

            int n = players.Count;

            while (n > 1)
            {
                n--;
                int x = rng.Next(n + 1);
                Player player = players[x];
                players[x] = players[n];
                players[n] = player;
            }
        }

        //! Method that shows the names of a random team
        /*!
            \return Names of people in a team, each name on a new line
        */
        public string PickRandomTeam()
        {
            return "\nTeam:\n"+teams.ElementAt(new Random().Next(teams.Count)).ToString();
        }


        public void AddNewPlayer(Player player)
        {
            if(!players.Contains(player))
            players.Add(player);
        }


        //! Method that shows all the player names grouped by team
        /*!
            \return names grouped by team, each name on a new line. Teams are seperated by a blanc line
        */
        public override string ToString()
        {
            string result = "\nTEAMS\n";

            foreach(Team team in teams)
            {
                result += team.ToString()+"\n";
            }
            return result;
        }

        //! Getter for number of teams
        /*!
            \return number of teams
        */
        public int GetNumberOfTeams()
        {
            return teams.Count;
        }

    }
}
