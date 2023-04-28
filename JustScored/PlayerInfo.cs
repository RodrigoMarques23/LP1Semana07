using System;

namespace JustScored
{
    public class PlayerInfo
    {

        private float maxScore;
        private string name;
        private int gamesPlayed;
        private int gamesWon;
        private string s = "No games played";
        public float MaxScore
        {
            get { return maxScore; }
            set { }
        }
        public string Name { get; }
        public float RateOfSuccess
        {
            get
            {
                return gamesWon / gamesPlayed;
            }
        }

        public void AddGame(bool win)
        {
            Console.WriteLine("One more game to the player");
            if (win == true)
            {
                gamesWon++;
                gamesPlayed++;
            }
            else
            {
                gamesPlayed++;
            }
        }
        public PlayerInfo(string playerName)
        {
            name = playerName;
        }

    }

}
