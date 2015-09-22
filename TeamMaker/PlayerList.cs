using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMaker
{
    class PlayerList
    {
        IList<Player> playerList;
        int soloCount;
        int duoCount;
        public int totalPlayers { get; set; }

        public PlayerList() {
            playerList = new List<Player>();
            soloCount = 0;
            duoCount = 0;
        }
        
        public void AddSolo(String name) {
            playerList.Add(new Player(null, name, 1));
            soloCount++;
            totalPlayers++;
        }

        public void AddDuo(String name, String teammateName)
        {
            Player teammate = new Player(null, teammateName, 0);
            playerList.Add(new Player(teammate, name, 2));
            duoCount++;
            totalPlayers += 2;
        }

        void Shuffle(int teamSize)
        {
            Random rng = new Random();
            int n = playerList.Count;
            int teamCount;
            bool runAgain;
            do {
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
                        teamCount += p.count;
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
            if (soloCount * (teamSize / 2) < duoCount || teamSize % 2 == 0)
                return null;
            Shuffle(teamSize);
            return ReAddTeammates();
        }

        IList<Player> ReAddTeammates()
        {
            IList<Player> tempList = new List<Player>();
            foreach (Player p in playerList)
            {
                if (p.teammate == null)
                    tempList.Add(p);
                else
                {
                    tempList.Add(p);
                    tempList.Add(p.teammate);
                }
            }
            return tempList;
        }
    }
}
