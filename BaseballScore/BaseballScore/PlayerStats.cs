using System.Collections.Generic;

namespace BaseballScore
{
    public class PlayerStats
    {
        public string PlayerName { get; }

        public string TeamName { get; }

        public List<InningRecord> InningRecords { get; set; }

        public PlayerStats(string playerName, string teamName)
        {
            PlayerName = playerName;
            TeamName = teamName;
            InningRecords = new List<InningRecord>();
        }
    }

    public static class GameStats
    {
        public static List<PlayerStats> GetAll()
        {
            return new List<PlayerStats>
            {
                new PlayerStats("Hank Erin", "Columbus Greens")
                {
                    InningRecords = new List<InningRecord>
                    {
                        new InningRecord(2, 1, 1),
                        new InningRecord(3, 0, 0),
                        new InningRecord(1, 1, 0),
                        new InningRecord(1, 1, 1),
                        new InningRecord(3, 0, 0),
                        new InningRecord(0, 0, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 1, 1),
                        new InningRecord(1, 0, 0),
                    }
                },
                new PlayerStats("Bob Ruth", "Saint Paul Triplets")
                {
                    InningRecords = new List<InningRecord>
                    {
                        new InningRecord(1, 0, 0),
                        new InningRecord(0, 0, 0),
                        new InningRecord(2, 1, 0),
                        new InningRecord(3, 0, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(3, 3, 1),
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 1, 1),
                    }
                },
                new PlayerStats("Joe DiGiorno", "Columbus Greens")
                {
                    InningRecords = new List<InningRecord>
                    {
                        new InningRecord(3, 2, 2),
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(3, 0, 0),
                        new InningRecord(3, 3, 2),
                        new InningRecord(0, 0, 0),
                        new InningRecord(0, 0, 0),
                        new InningRecord(3, 1, 1),
                    }
                },
                new PlayerStats("Wade Bugs", "Saint Paul Triplets")
                {
                    InningRecords = new List<InningRecord>
                    {
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 1, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(3, 2, 2),
                        new InningRecord(1, 1, 1),
                        new InningRecord(2, 1, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(1, 0, 0),
                        new InningRecord(0, 0, 0),
                    }
                },
            };
        }
    }
}
