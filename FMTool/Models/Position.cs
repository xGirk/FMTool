namespace FMTool.Models
{
    public record Position
    {
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public string Name { get; set; }
        public int CurrentPlayers { get; set; } = 0;

        public Position(string name, int maxPlayers)
        {
            Name = name;
            MaxPlayers = maxPlayers;
        }

        public Position(string name, int maxPlayers, int minPlayers)
            :this(name, maxPlayers)
        {
            MinPlayers = minPlayers;
        }

        public bool Add()
        {
            if (CurrentPlayers < MaxPlayers)
            {
                CurrentPlayers++;
                return true;
            }
            return false;
        }
    }
}
