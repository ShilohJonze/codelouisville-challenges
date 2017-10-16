using System;
using System.Linq;

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
            DisplayTeamScore("Columbus Greens");
            DisplayTeamScore("Saint Paul Triplets");

            Console.ReadLine();
        }

        private static void DisplayTeamScore(string teamName)
        {
            const int numInnings = 9;

            var runCounts = Enumerable.Repeat(0, numInnings).ToList();

            Console.Write("{0,-20}", teamName);
            foreach (var playerStats in GameStats.GetAll())
            {
                if (playerStats.TeamName != teamName)
                    continue;

                for (var inning = 0; inning < numInnings; inning++)
                    runCounts[inning] += playerStats.InningRecords[inning].NumRuns;
            }

            foreach (var runCount in runCounts)
                Console.Write("{0,3}", runCount);
            Console.WriteLine("{0,7}", runCounts.Sum());
        }
    }
}
