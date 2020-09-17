using System.Collections.Generic;
using System.Linq;

namespace TeamMaker
{
    class PlayerList
    {
        private readonly IList<Player> playerList;
        private int soloCount;
        private int duoCount;
        public int TotalPlayers { get; set; }

        /// <summary>
        /// Initializes a new empty playerlist with 0 counts.
        /// </summary>
        public PlayerList()
        {
            playerList = new List<Player>();
            soloCount = 0;
            duoCount = 0;
        }

        /// <summary>
        /// Adds a solo to the player list.
        /// </summary>
        /// <param name="player"></param>
        public void AddSolo(Player player)
        {
            playerList.Add(player);
            soloCount++;
            TotalPlayers++;
        }

        /// <summary>
        /// Adds a duo to the player list.
        /// </summary>
        /// <param name="player"></param>
        public void AddDuo(Player player)
        {
            playerList.Add(player);
            duoCount++;
            TotalPlayers += 2;
        }

        /// <summary>
        /// Checks if you have enough players to build teams for specified team size.
        /// </summary>
        /// <param name="teamSize"></param>
        /// <returns></returns>
        public bool HasEnoughPlayersForTeamSize(int teamSize)
        {
            return this.TotalPlayers % teamSize != 0;
        }

        /// <summary>
        /// Will return the remaining number of players needed to create teams for the team size you want.
        /// </summary>
        /// <param name="teamSize"></param>
        /// <returns></returns>
        public int GetRemainingNumberOfPlayerssForTeamSize(int teamSize)
        {
            return teamSize - (this.TotalPlayers % teamSize);
        }

        /// <summary>
        /// Will return true if you have enough solos to actually be able to fill all of the teams up.
        /// For example: 5 duos and a team size of 5 will return false since it is impossible to fill teams of 5 evenly without splitting a duo.
        /// </summary>
        /// <param name="teamSize"></param>
        /// <returns></returns>
        public bool HasEnoughSolosForTeamSize(int teamSize)
        {
            // Having trouble wrapping my head around this check.  Wrote this 5 years ago and I'm not sure why it works?
            return (this.soloCount * (teamSize / 2) < this.duoCount && teamSize % 2 != 0);
        }

        /// <summary>
        /// Gets the remaining number of solos needed to be able to fill all teams without splitting up a duo.
        /// </summary>
        /// <param name="teamSize"></param>
        /// <returns></returns>
        public int GetRemainingNumberOfSolosForTeamSize(int teamSize)
        {
            // I think this is right?  Seems like the check above might be too complex?
            return duoCount - soloCount;
        }

        /// <summary>
        /// Simply does a Fisher-Yates shuffle on the list, followed by checking if the shuffled list produced a valid set of teams.
        /// If we didn't get a valid set of teams, we shuffle again.
        /// </summary>
        /// <param name="teamSize"></param>
        private void ShufflePlayerList(int teamSize)
        {
            bool runAgain;
            // Potential for an infinite loop here.  There technically was one here that I fixed.
            // If we somehow get a combination of solos and duos that will never make a team, and we didn't catch it before for some reason, then this will loop forever.
            do
            {
                runAgain = false;
                int n = this.playerList.Count;
                int teamCount = 0;
                while (n > 1)
                {
                    n--;
                    int k = ThreadLocalRandom.Next(n + 1);
                    Player tempPlayer = playerList[k];
                    playerList[k] = playerList[n];
                    playerList[n] = tempPlayer;
                }
                // Need to do this to make sure that the shuffled players with actually fit into the team size selected.
                // Will count up to the team size and reset the counter every time it hits the team size.  If we go over, our teams won't fit in the team size.
                foreach (Player p in playerList)
                {
                    if (!runAgain)
                    {
                        teamCount += p.Count;
                        if (teamCount == teamSize)
                            teamCount = 0;
                        else if (teamCount > teamSize)
                            runAgain = true;
                    }
                }
            } while (runAgain);
        }

        /// <summary>
        /// Shuffles the players and returns an IEnumerable of Team objects representing the teams.
        /// </summary>
        /// <param name="teamSize"></param>
        /// <returns></returns>
        public IEnumerable<Team> BuildTeams(int teamSize)
        {
            ShufflePlayerList(teamSize);
            return BuildTeamsList(teamSize);
        }

        /// <summary>
        /// Flattens the shuffled list into a list of players unpaired from their duos and chunks them into Team objects.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Team> BuildTeamsList(int teamSize)
        {
            var tempList = new List<Player>(TotalPlayers);
            foreach (Player p in playerList)
            {
                if (p.Teammate == null)
                    tempList.Add(p);
                else
                {
                    tempList.Add(p);
                    tempList.Add(p.Teammate);
                }
            }
            return tempList.Select((value, index) => new { Index = index, Value = value })
            .GroupBy(x => x.Index / teamSize)
            .Select(x => new Team(x.Select(v => v.Value)));
        }
    }
}
