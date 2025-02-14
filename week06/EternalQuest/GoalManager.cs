using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> goals;
        public int TotalPoints { get; private set; }

        public GoalManager()
        {
            goals = new List<Goal>();
            TotalPoints = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordGoalEvent(string goalName)
        {
            Goal goal = goals.Find(g => g.Name == goalName);
            if (goal != null)
            {
                goal.RecordEvent();
                TotalPoints += goal.Points;
                Console.WriteLine($"Total Points: {TotalPoints}");
            }
            else
            {
                Console.WriteLine("Goal not found!");
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine($"{goal.Name}: {goal.GetStatus()}");
            }
        }

        public void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(TotalPoints);
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points}");
                }
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists("goals.txt"))
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    TotalPoints = int.Parse(reader.ReadLine());
                    goals.Clear();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(',');

                        string goalType = parts[0];
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        int goalPoints = int.Parse(parts[3]);

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                                break;
                            case "EternalGoal":
                                goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                                break;
                            case "CheckListGoal":
                                int targetCount = int.Parse(parts[4]);
                                int bonusPoints = int.Parse(parts[5]);
                                goals.Add(new CheckListGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints));
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No saved data found.");
            }
        }
    }
}