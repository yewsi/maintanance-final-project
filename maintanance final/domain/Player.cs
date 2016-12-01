using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.domain
{
    //! Class to represent a player 
    /*!
      \author Adam Boghe
      \date 2016
      
    */
    class Player
    {
        private string name;
        private int wins;
        private int losses;

        //! Player class constructor.
        /*!
          \param name of the player
        */
        public Player(string name)
        {
            Name = name;
        }

        //! Method that increments the player's wins with 1
        public void IncrementWins()
        {
            wins++;
        }

        //! Method that increments the player's losses with 1
        public void IncrementLosses()
        {
            losses++;
        }

        //! Method that cheks if Player objects are the same        
        /*!
          \return boolean true if objects are the same
        */
        public bool Equals(string name)
        {
            return this.name.Equals(name);
        }

        //Properties

        //! Property for rating variable
        /*!
          \property Get-property for the review's rating
        */
        public string Name
        {
            get;
            set;
        }
    }
}
