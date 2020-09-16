using System;
using System.Collections.Generic;

namespace TeamMaker
{
    class PlayerList
    {
        private readonly IList<Player> playerList;
        private int soloCount;
        private int duoCount;
        public int TotalPlayers { get; set; }

        public PlayerList()
        {
            playerList = new List<Player>();
            soloCount = 0;
            duoCount = 0;
        }

        public void AddSolo(Player player)
        {
            playerList.Add(player);
            soloCount++;
            TotalPlayers++;
        }

        public void AddDuo(Player player)
        {
            playerList.Add(player);
            duoCount++;
            TotalPlayers += 2;
        }

        public bool HasEnoughPlayersToFillTeamsForTeamSize(int teamSize)
        {
            return this.TotalPlayers % teamSize != 0;
        }

        public int GetRequiredNumberOfPlayersToFillForTeamSize(int teamSize)
        {
            return teamSize - (this.TotalPlayers % teamSize);
        }

        public bool HasEnoughSolosToMatchWithDuosForTeamSize(int teamSize)
        {
            return (this.soloCount * (teamSize / 2) < this.duoCount && teamSize % 2 != 0);
        }

        private void Shuffle(int teamSize)
        {
            Random rng = new Random();
            int n = playerList.Count;
            int teamCount;
            bool runAgain;
            do
            {
                teamCount = 0;
                runAgain = false;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Player tempPlayer = playerList[k];
                    playerList[k] = playerList[n];
                    playerList[n] = tempPlayer;
                }
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

        public IList<Player> BuildTeams(int teamSize)
        {
            Shuffle(teamSize);
            return ReAddTeammates();
        }

        private IList<Player> ReAddTeammates()
        {
            IList<Player> tempList = new List<Player>();
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
            return tempList;
        }
    }
}
