using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public int TimesRecorded { get; private set; }

        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
            TimesRecorded = 0;
        }

        public override void RecordEvent()
        {
            TimesRecorded++;
            Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
        }

        public override string GetStatus()
        {
            return $"[Eternal] Earned {TimesRecorded * Points} points so far.";
        }
    }
}