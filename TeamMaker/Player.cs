using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMaker
{
    class Player
    {
        public Player teammate { get; set; }
        public String name { get; set; }
        public int count { get; set; }

        public Player(Player team, String playerName, int playerCount)
        {
            teammate = team;
            name = playerName;
            count = playerCount;
        }
    }
}
