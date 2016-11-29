using maintanance_final.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.service
{
    interface ITeamManagerService
    {
        void AddPlayer(Player player);
        void DevidePlayersIntoTeams(int numberOfTeams);
        string PickRandomTeam();
    }
}
