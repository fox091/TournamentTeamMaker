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

        public PlayerList() {
            playerList = new List<Player>();
            soloCount = 0;
            duoCount = 0;
        }
        
        public void AddSolo(String name) {
            playerList.Add(new Player(null, name, 1));
            soloCount++;
        }

        public void AddDuo(String name, String teammateName)
        {
            Player teammate = new Player(null, teammateName, 0);
            playerList.Add(new Player(teammate, name, 2));
            duoCount += 2;
        }

        void Shuffle(int teamSize)
        {
            Random rng = new Random();
            int n = playerList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Player tempPlayer = playerList[k];
                playerList[k] = playerList[n];
                playerList[n] = tempPlayer;
            }
        }

        public IList<Player> BuildTeams()
        {
            return ReAddTeammates();
        }

        IList<Player> ReAddTeammates()
        {
            IList<Player> tempList = new List<Player>();

            return tempList;
        }
    }
}
