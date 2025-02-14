using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();

            manager.AddGoal(new SimpleGoal("Run Marathon", "Complete a full marathon", 1000));
            manager.AddGoal(new EternalGoal("Read Scriptures", "Read scriptures daily", 100));
            manager.AddGoal(new CheckListGoal("Attend Temple", "Attend the temple 10 times", 50, 10, 500));

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Eternal Quest - Choose an option:");
                Console.WriteLine("1. Display Goals");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.DisplayGoals();
                        break;
                    case "2":
                        Console.WriteLine("Enter the goal name to record: ");
                        string goalName = Console.ReadLine();
                        manager.RecordGoalEvent(goalName);
                        break;
                    case "3":
                        manager.SaveToFile();
                        Console.WriteLine("Goals saved.");
                        break;
                    case "4":
                        manager.LoadFromFile();
                        Console.WriteLine("Goals loaded.");
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}