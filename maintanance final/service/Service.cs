using maintanance_final.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.service
{
    class Service : ITeamManagerService
    {
        private TeamManager manager;

        public Service()
        {
            manager = new TeamManager();
        }

        public void AddPlayer(Player player)
        {
            manager.AddNewPlayer(player);
        }

        public void DevidePlayersIntoTeams(int numberOfTeams)
        {
            manager.CreateTeams(numberOfTeams);
        }

        public string PickRandomTeam()
        {
            return manager.PickRandomTeam();
        }

        public void

    }
}
