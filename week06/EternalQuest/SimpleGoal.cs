using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public bool IsCompleted { get; set; }

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            IsCompleted = false;
        }

        public override void RecordEvent()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
            }
            else
            {
                Console.WriteLine($"Goal '{Name}' is already completed.");
            }
        }

        public override string GetStatus()
        {
            return IsCompleted ? "[X] Completed" : "[ ] Not Completed";
        }
    }
}