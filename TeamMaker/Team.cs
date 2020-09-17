using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamMaker
{
    class Team
    {
        public readonly IEnumerable<Player> Players;
        public readonly int PlayerCount;

        public Team(IEnumerable<Player> players)
        {
            this.Players = players;
            this.PlayerCount = this.Players.Count();
        }
    }
}
