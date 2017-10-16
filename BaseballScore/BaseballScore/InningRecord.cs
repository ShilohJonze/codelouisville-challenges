namespace BaseballScore
{
    public class InningRecord
    {
        public int TimesAtBat { get; }

        public int NumHits { get; }

        public int NumRuns { get; }

        public InningRecord(int timesAtBat, int numHits, int numRuns)
        {
            TimesAtBat = timesAtBat;
            NumHits = numHits;
            NumRuns = numRuns;
        }
    }
}
