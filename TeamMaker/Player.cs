namespace TeamMaker
{
    class Player
    {
        public Player Teammate { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public Player(Player team, string playerName, int playerCount)
        {
            Teammate = team;
            Name = playerName;
            Count = playerCount;
        }

        public string GetPlayerOrDuoNames()
        {
            if(this.Teammate == null)
            {
                return this.Name;
            }
            else
            {
                return $"{this.Name} | {this.Teammate.Name}";
            }
        }
    }
}
