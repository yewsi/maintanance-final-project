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
        //! Method that adds a new player to the program       
        void AddPlayer(string player);

        //! Method that creates teams and divide the players in them
        /*!
         \parameter number of teams to be created 
        */
        void DevidePlayersIntoTeams(int numberOfTeams);

        //! Method that shows the names of a random team
        /*!
            \return Names of people in a team, each name on a new line
        */
        string PickRandomTeam();

        //! Method that shows all the player names grouped by team
        /*!
            \return names grouped by team, each name on a new line. Teams are seperated by a blanc line
        */
        string ShowTeams();
    }
}
