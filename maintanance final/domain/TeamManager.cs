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
            return "\nTeam:\n"+teams.ElementAt(new Random().Next(teams.Count)).ToString();
        }

        public void AddNewPlayer(Player player)
        {
            if(!players.Contains(player))
            players.Add(player);
        }

        public override string ToString()
        {
            string result = "\nTEAMS\n";

            foreach(Team team in teams)
            {
                result += team.ToString()+"\n";
            }
            return result;
        }

        public int GetNumberOfTeams()
        {
            return teams.Count;
        }

    }
}
