using System;

namespace JustScored
{
    public class PlayerInfo
    {

        private float maxScore;
        private int gamesPlayed;
        private int gamesWon;
        public float MaxScore
        {
            get { return maxScore; }
            set { if (value > maxScore) maxScore = value; }
        }
        public string Name { get; }
        public float RateOfSuccess
        {
            get
            {
                return (float)gamesWon / (float)gamesPlayed;
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
            Name = playerName;
        }

    }

}
