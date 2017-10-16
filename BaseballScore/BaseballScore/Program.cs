using System;

namespace BaseballScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Batting Averages");
            Console.WriteLine("--------------------");
            foreach (var playerStats in GameStats.GetAll())
            {
                var totalAtBats = 0;
                var totalHits = 0;
                foreach (var inningRecord in playerStats.InningRecords)
                {
                    totalAtBats += inningRecord.TimesAtBat;
                    totalHits += inningRecord.NumHits;
                }

                Console.WriteLine("{0,13}: {1:0.000}", playerStats.PlayerName, (float)totalHits / totalAtBats);
            }

            Console.WriteLine();
            Console.WriteLine("Team                  1  2  3  4  5  6  7  8  9  Final");
            Console.WriteLine("------------------------------------------------------");
            // TODO: Bonus: For each team display the runs per inning and final score.

            Console.ReadLine();
        }
    }
}
