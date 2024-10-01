// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using AstronautConsoleApp.Factories;
using AstronautConsoleApp.Managers;
using AstronautConsoleApp.Observers;
using AstronautConsoleApp.Models;
using System;

namespace AstronautConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScheduleManager scheduleManager = ScheduleManager.Instance;
            ConsoleObserver observer = new ConsoleObserver();
            scheduleManager.AddObserver(observer);
            Factories.TaskFactory taskFactory = new Factories.TaskFactory();

            while (true)
            {
                Console.WriteLine("Enter command (Add/View/Remove/Exit):");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter Task Description:");
                        string description = Console.ReadLine();

                        Console.WriteLine("Enter Start Time (HH:mm):");
                        if (!DateTime.TryParse(Console.ReadLine(), out DateTime startTime))
                        {
                            Console.WriteLine("Error: Invalid time format.");
                            continue;
                        }

                        Console.WriteLine("Enter End Time (HH:mm):");
                        if (!DateTime.TryParse(Console.ReadLine(), out DateTime endTime))
                        {
                            Console.WriteLine("Error: Invalid time format.");
                            continue;
                        }

                        if (endTime <= startTime)
                        {
                            Console.WriteLine("Error: End time must be after start time.");
                            continue;
                        }

                        Console.WriteLine("Enter Priority (High/Medium/Low):");
                        string priorityInput = Console.ReadLine().ToLower();
                        int priorityLevel = priorityInput switch
                        {
                            "high" => 1,
                            "medium" => 2,
                            "low" => 3,
                            _ => 3
                        };

                        var task = taskFactory.CreateTask(description, startTime, endTime, priorityLevel);
                        scheduleManager.AddTask(task);
                        break;

                    case "view":
                        var tasks = scheduleManager.ViewAllTasks();
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks scheduled for the day.");
                        }
                        else
                        {
                            foreach (var t in tasks)
                            {
                                string priorityName = t.PriorityLevel switch
                                {
                                    1 => "High",
                                    2 => "Medium",
                                    3 => "Low",
                                    _ => "Unknown"
                                };
                                Console.WriteLine($"{t.StartTime:HH:mm} - {t.EndTime:HH:mm}: {t.Description} [{priorityName}]");
                            }
                        }
                        break;

                    case "remove":
                        Console.WriteLine("Enter Task Description to Remove:");
                        string taskToRemove = Console.ReadLine();
                        if (!scheduleManager.RemoveTaskByDescription(taskToRemove))
                        {
                            Console.WriteLine("Error: Task not found.");
                        }
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}





