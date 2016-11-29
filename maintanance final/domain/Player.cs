using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintanance_final.domain
{
    class Player
    {
        private string name;
        private int wins;
        private int losses;

        public Player(string name)
        {
            Name = name;
        }

        public void IncrementWins()
        {
            wins++;
        }

        public void IncrementLosses()
        {
            losses++;
        }

        public bool Equals(string name)
        {
            return this.name.Equals(name);
        }

        //Properties

        public string Name
        {
            get;
            set;
        }
    }
}
