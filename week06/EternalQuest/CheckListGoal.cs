using System;

namespace EternalQuest
{
    public class CheckListGoal : Goal
    {
        public int TargetCount { get; set; }
        public int CurrentCount { get; set; }
        public int BonusPoints { get; set; }

        public CheckListGoal(string name, string description, int points, int targetCount, int bonusPoints)
            : base(name, description, points)
        {
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            CurrentCount = 0;
        }

        public override void RecordEvent()
        {
            if (CurrentCount < TargetCount)
            {
                CurrentCount++;
                Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");

                if (CurrentCount == TargetCount)
                {
                    Console.WriteLine($"Goal '{Name}' completed! You earned a bonus of {BonusPoints} points.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{Name}' is already completed.");
            }
        }

        public override string GetStatus()
        {
            return $"Completed {CurrentCount}/{TargetCount} times.";
        }
    }
}