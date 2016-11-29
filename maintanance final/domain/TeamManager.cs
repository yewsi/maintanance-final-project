using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.domain
{
    class TeamManager
    {
        IList<Player> players;
        IList<Team> teams;

        public TeamManager()
        {
            players = new List<Player>();
            teams = new List<Team>();
        }

        public void CreateTeams(int numberOfTeams)
        {

            for (int i = 0; i < numberOfTeams; i++)
            {
                teams.Add(new Team());
            }

            for (int i = 0; i<teams.Count; i++)
            {
                this.ShufflePlayers();

                //teamSize MOET BETER!!! om beurt eentje bij een team steken tot op?
                double teamSize = Math.Ceiling((double)players.Count / numberOfTeams);
                for(int j = 0; j < teamSize; j++)
                {
                    if(players[j]!=null)
                    teams.ElementAt(i).AddPlayerToTeam(players[j]);
                }
            }


        }

        public void ShufflePlayers()
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

        public string PickRandomTeam()
        {
            return teams.ElementAt(new Random().Next(teams.Count)).ToString();
        }

        public void AddNewPlayer(Player player)
        {
            if(!players.Contains(player))
            players.Add(player);
        }


    }
}
